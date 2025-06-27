using WinterCubeTimer.model;
using WinterCubeTimer.repository;

namespace WinterCubeTimer.service;

public interface ITimeService {
    public long calculateAverage(List<SolveTime> times);
    public List<string> generateScramble();
    public Task<SolveTime> create(SolveTime solveTime);
    public Task<SolveTime> update(long id, SolveTime solveTime);
    public Task<SolveTime> updateIsPlusTwo(long id, bool isPlusTwo);
    public Task<SolveTime> updateIsDnf(long id, bool isDnf);
    public Task<int> delete(long id);
    public Task<SolveTime> getById(long id);
    public Task<int> getNumberOfSolvesBySession(int session);
    public Task<List<SolveTime>> getSolveTimeListBySession(int session);
    public Task<int> deleteAllBySession(int session);
    public Task<SolveTime> getLatestTimeBySession(int session);
    public Task<List<SolveTime>> getLatestXSolveTimeListOrderBySolveTime(int numberToGet, int session);
    public Task<List<SolveTime>> getLatestXSolveTimeListOrderByCreatedTime(int numberToGet, int session);
    public Task<SolveTime> getBestTimeBySession(int session);
}

