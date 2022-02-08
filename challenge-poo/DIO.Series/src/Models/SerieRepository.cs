using DIO.Series.src.interfaces;

namespace DIO.Series.src
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> serieList = new List<Serie>();
        public void Insert(Serie entitie)
        {
            serieList.Add(entitie);
        }
        public List<Serie> List()
        {
            return serieList;
        }
        public int NextId()
        {
            return serieList.Count;
        }
        public void Remove(int id)
        {
            serieList[id].Remove();
        }
        public Serie ReturnById(int id)
        {
            return serieList[id];
        }
        public void Update(int id, Serie entitie)
        {
            serieList[id] = entitie;
        }
    }
}