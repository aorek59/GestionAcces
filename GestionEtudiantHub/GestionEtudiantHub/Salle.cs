using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using.GestionEtudiantHub.Models
{
    public class Salle
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SalleManager
    {
        public static List<Salle> GetSalles()
        {
            var salles = new List<Salle>();

            salles.Add(new Salle() { Id = 1, Name = "B01" });
            salles.Add(new Salle() { Id = 2, Name = "B02" });
            salles.Add(new Salle() { Id = 3, Name = "B03" });
            salles.Add(new Salle() { Id = 4, Name = "B04" });
            salles.Add(new Salle() { Id = 5, Name = "B05" });
            salles.Add(new Salle() { Id = 6, Name = "B06" });
            salles.Add(new Salle() { Id = 7, Name = "B07" });
            salles.Add(new Salle() { Id = 8, Name = "B08" });
            salles.Add(new Salle() { Id = 9, Name = "B09" });
            salles.Add(new Salle() { Id = 10, Name = "B10" });
            salles.Add(new Salle() { Id = 11, Name = "B11" });


            return salles;

        }
    }
}
