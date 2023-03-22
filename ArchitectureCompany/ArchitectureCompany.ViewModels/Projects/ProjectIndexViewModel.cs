namespace ArchitectureCompany.ViewModels.Projects
{
    public class ProjectIndexViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BuildingType { get; set; }
        public int Capacity { get; set; }
        public string ReleaseDate { get; set; }
        public int FloorArea { get; set; }
        public int FloorsCount { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; } = "https://media.istockphoto.com/id/1063723682/photo/hand-sketching-a-designer-villa-with-pool.jpg?s=612x612&w=0&k=20&c=SlIacvwSEEsZ-2imWLDk6dC0glhaWEg-pOGFSK4YQuI=";
    }
}
