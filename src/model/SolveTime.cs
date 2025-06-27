using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinterCubeTimer.model {
    public class SolveTime{
        [Key]
        public int id { get; set; }
        [Column("solve_session")]
        public int solveSession { get; set; }
        [Column("solve_time_in_milliseconds")]
        public long solveTimeInMilliseconds { get; set; }
        [Column("solve_initial_time_in_milliseconds")]
        public long solveInitialTimeInMilliseconds { get; set; }
        [Column("solve_time")]
        [MaxLength(255)]
        public string solveTime { get; set; }
        [Column("is_plus_two")]
        public bool isPlusTwo { get; set; }
        [Column("is_dnf")]
        public bool isDnf { get; set; }
        [Column("solve_scramble")]
        [MaxLength(255)]
        public string solveScramble { get; set; }
        [Column("created_at")]
        public DateTime createdAt { get; set; }
        [Column("updated_at")]
        public DateTime updatedAt { get; set; }

        public SolveTime() {
            
        }
        
        public SolveTime(int id, int solveSession, long solveTimeInMilliseconds, long solveInitialTimeInMilliseconds, string solveTime, bool isPlusTwo, bool isDnf, string solveScramble, DateTime createdAt, DateTime updatedAt) {
            this.id = id;
            this.solveSession = solveSession;
            this.solveTimeInMilliseconds = solveTimeInMilliseconds;
            this.solveInitialTimeInMilliseconds = solveInitialTimeInMilliseconds;
            this.solveTime = solveTime;
            this.isPlusTwo = isPlusTwo;
            this.isDnf = isDnf;
            this.solveScramble = solveScramble;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }
        public SolveTime(int solveSession, long solveTimeInMilliseconds, long solveInitialTimeInMilliseconds, string solveTime, bool isPlusTwo, bool isDnf, string solveScramble, DateTime createdAt, DateTime updatedAt) {
            this.solveSession = solveSession;
            this.solveTimeInMilliseconds = solveTimeInMilliseconds;
            this.solveInitialTimeInMilliseconds = solveInitialTimeInMilliseconds;
            this.solveTime = solveTime;
            this.isPlusTwo = isPlusTwo;
            this.isDnf = isDnf;
            this.solveScramble = solveScramble;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }
    }
}