using MagicVillas.Models.Dto;

namespace MagicVillas.Data
{
    public static class VillaStore
    {
        public static List <VillaDTO> villalist = new List<VillaDTO>(){
                new VillaDTO{Id=1, Name="Villa 1", Description="This is Villa 1", Price=1000000},
                new VillaDTO{Id=2, Name="Villa 2", Description="This is Villa 2", Price=2000000},
                new VillaDTO{Id=3, Name="Villa 3", Description="This is Villa 3", Price=3000000}
            };
    }
}
