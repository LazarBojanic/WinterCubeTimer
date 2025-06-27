using Microsoft.EntityFrameworkCore;
using WinterCubeTimer.model;
using WinterCubeTimer.repository;
using WinterCubeTimer.util;

namespace WinterCubeTimer.service;

public class TimeService : ITimeService {
    private TimeRepository timeRepository { get; set; }
    public Cube cube{ get; set; }
    
    public TimeService(TimeRepository timeRepository) {
        this.timeRepository = timeRepository;
        cube = new Cube();
    }

    public long calculateAverage(List<SolveTime> times) {
        int numOfDnfs = 0;
        int indexOfDnf = 0;
        List<SolveTime> sortedTimes = times.OrderBy(time => time.solveTimeInMilliseconds).ToList();
        long bestTime = sortedTimes[0].solveTimeInMilliseconds;
        long worstTime = sortedTimes[^1].solveTimeInMilliseconds;
        long sumOfTimes = 0;
        int numOfTimesWithoutBestAndWorst = sortedTimes.Count - 2;
        for(int i = 0; i < sortedTimes.Count; i++) {
            if (sortedTimes[i].isDnf) {
                numOfDnfs++;
                if (numOfDnfs > 1) {
                    return 0;
                }
                indexOfDnf = i;
            }
            else {
                sumOfTimes += sortedTimes[i].solveTimeInMilliseconds;
            }
        }
        if (numOfDnfs == 1) {
            if (indexOfDnf == 0) {
                sumOfTimes -= sortedTimes[1].solveTimeInMilliseconds;
            }
            else {
                sumOfTimes -= bestTime;
            }
        }
        else {
            sumOfTimes -= (bestTime + worstTime);
        }
        return sumOfTimes / numOfTimesWithoutBestAndWorst;
    }
    public List<string> generateScramble() {
        List<string> scramble = new List<string>();
        int numOfTurns = Util.random.Next(18, 22);
        int minDoubleTurns = Math.Min(numOfTurns / 2, 4);
        int doubleTurns = Util.random.Next(minDoubleTurns, numOfTurns);
        string previousTurn = "";
        for (int i = 0; i < numOfTurns; i++) {
            string face = Util.turns[Util.random.Next(Util.turns.Length)];
            while (face == previousTurn || isParallel(face, previousTurn)) {
                face = Util.turns[Util.random.Next(Util.turns.Length)];
            }
            string turnType = getTurnType(doubleTurns > 0);
            scramble.Add(face + turnType);
            previousTurn = face;
            if (turnType == "2") {
                doubleTurns--;
            }
        }
        return scramble;
    }
    private string getTurnType(bool allowDoubleTurn) {
        if (allowDoubleTurn) {
            return Util.random.Next(3) == 0 ? "2" : (Util.random.Next(2) == 0 ? "'" : "");
        }
        return Util.random.Next(2) == 0 ? "'" : "";
    }
    private bool isParallel(string face1, string face2) {
        return (face1 == "U" && face2 == "D") || (face1 == "D" && face2 == "U") ||
               (face1 == "L" && face2 == "R") || (face1 == "R" && face2 == "L") ||
               (face1 == "F" && face2 == "B") || (face1 == "B" && face2 == "F");
    }

    public async Task<SolveTime> create(SolveTime solveTime) {
        var addedSolveTime = await timeRepository.solveTime.AddAsync(solveTime);
        await timeRepository.SaveChangesAsync();
        return addedSolveTime.Entity;
    }

    public async Task<SolveTime> update(long id, SolveTime solveTime) {
        var currentSolveTime = await getById(id);
        if (currentSolveTime != null) {
            currentSolveTime.solveSession = solveTime.solveSession;
            currentSolveTime.solveTimeInMilliseconds = solveTime.solveTimeInMilliseconds;
            currentSolveTime.solveInitialTimeInMilliseconds = solveTime.solveInitialTimeInMilliseconds;
            currentSolveTime.solveTime = solveTime.solveTime;
            currentSolveTime.isPlusTwo = solveTime.isPlusTwo;
            currentSolveTime.isDnf = solveTime.isDnf;
            currentSolveTime.solveScramble = solveTime.solveScramble;
            currentSolveTime.createdAt = solveTime.createdAt;
            currentSolveTime.updatedAt = solveTime.updatedAt;
        }
        await timeRepository.SaveChangesAsync();
        return currentSolveTime;
    }

    public async Task<SolveTime> updateIsPlusTwo(long id, bool isPlusTwo) {
        var currentSolveTime = await getById(id);
        currentSolveTime.isPlusTwo = isPlusTwo;
        await timeRepository.SaveChangesAsync();
        return currentSolveTime;
    }

    public async Task<SolveTime> updateIsDnf(long id, bool isDnf) {
        var currentSolveTime = await getById(id);
        currentSolveTime.isPlusTwo = isDnf;
        await timeRepository.SaveChangesAsync();
        return currentSolveTime;
    }

    public async Task<int> delete(long id) {
        int res = await timeRepository.solveTime.Where(entity => entity.id == id).ExecuteDeleteAsync();
        await timeRepository.SaveChangesAsync();
        return res;
    }

    public async Task<SolveTime> getById(long id) {
        SolveTime res = await timeRepository.solveTime.Where(entity => entity.id == id).FirstOrDefaultAsync();
        await timeRepository.SaveChangesAsync();
        return res;
    }

    public async Task<int> getNumberOfSolvesBySession(int session) {
        int res = await timeRepository.solveTime.CountAsync(entity => entity.solveSession == session);
        await timeRepository.SaveChangesAsync();
        return res;
    }

    public async Task<List<SolveTime>> getSolveTimeListBySession(int session) {
        List<SolveTime> res = await timeRepository.solveTime.Where(entity => entity.solveSession == session).OrderBy(entity => entity.createdAt).ToListAsync();
        await timeRepository.SaveChangesAsync();
        return res;
    }

    public async Task<int> deleteAllBySession(int session) {
        int res = await timeRepository.solveTime.Where(entity => entity.solveSession == session).ExecuteDeleteAsync();
        await timeRepository.SaveChangesAsync();
        return res;
    }

    public async Task<SolveTime> getLatestTimeBySession(int session) {
        SolveTime res = await timeRepository.solveTime.OrderByDescending(entity => entity.createdAt).FirstOrDefaultAsync();
        await timeRepository.SaveChangesAsync();
        return res;
    }
    public async Task<List<SolveTime>> getLatestXSolveTimeListOrderBySolveTime(int numberToGet, int session) {
        List<SolveTime> res = await timeRepository.solveTime.Where(entity => entity.solveSession == session).OrderBy(entity => entity.solveTimeInMilliseconds).Take(numberToGet).ToListAsync();
        await timeRepository.SaveChangesAsync();
        return res;
    }
    public async Task<List<SolveTime>> getLatestXSolveTimeListOrderByCreatedTime(int numberToGet, int session) {
        List<SolveTime> res = await timeRepository.solveTime.Where(entity => entity.solveSession == session).OrderByDescending(entity => entity.createdAt).Take(numberToGet).ToListAsync();
        await timeRepository.SaveChangesAsync();
        return res;
    }

    public async Task<SolveTime> getBestTimeBySession(int session) {
        SolveTime res = await timeRepository.solveTime.Where(entity => entity.solveSession == session).OrderBy(entity => entity.solveTimeInMilliseconds).FirstOrDefaultAsync();
        await timeRepository.SaveChangesAsync();
        return res;
    }
}