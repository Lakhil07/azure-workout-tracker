namespace WorkoutTracker.Api.Models
{
    public class Workout
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Exercise { get; set; } = string.Empty;
        public int sets { get; set; }

        public int Reps { get; set; }

        public double Weight { get; set; }

        public DateTime Date { get; set; }
        
    }
}