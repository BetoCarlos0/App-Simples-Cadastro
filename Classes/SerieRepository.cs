

namespace App_Simples_Cadastro
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();
        public void Delete(int id)
        {
            listSerie[id].Delete();
        }

        public void Insert(Serie entity)
        {
            listSerie.Add(entity);
        }

        public List<Serie> List()
        {
            return listSerie;
        }

        public int NextId()
        {
            return listSerie.Count();
        }

        public Serie ReturnId(int id)
        {
            return listSerie[id];
        }

        public void Update(int id, Serie entity)
        {
            listSerie[id] = entity;
        }
    }
}