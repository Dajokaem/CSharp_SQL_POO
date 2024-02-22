
using System.Data.SqlClient;
namespace Practica_SQL_POO
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7MHBJQ0 ; database=colegio ; integrated security = true");
            conexion.Open();
            bool status = true;
            
            do
            {

            } while (status);

        }
        public void menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Registrar Alumno");
            Console.WriteLine("2. Registrar Examen");
        }
    }
}

class Alumno
{
    public int id;
    public string DPI;
    public string nm;
    public string ape;
    public List<Escrito> es = new List<Escrito>();
    public List<Oral> or = new List<Oral>();
    public Alumno(int id, string DPI, string nm, string ape)
    {
        this.id = id;
        this.DPI = DPI;
        this.nm = nm;
        this.ape = ape;
    }
    

}

class Examen
{
    public int id;
    public DateTime fecha;
    public int Dura;

    public Examen(int id, DateTime fecha, int dura)
    {
        this.id = id;
        this.fecha = fecha;
        Dura = dura;
    }

}

class Escrito : Examen
{
    public int Nota;

    public Escrito(int id, DateTime fecha, int dura, int nota) : base(id, fecha, dura)
    {

    }
}
class Oral: Examen
{
    public string nivel="";

    public Oral(int id, DateTime fecha, int dura, string nivel) : base(id, fecha, dura)
    {
    }
}

