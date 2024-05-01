
namespace Calificaciones.Class
{
    public class calcular
    {
        public void Clasificaciones()

        {
            int Calificacion_1 = 0;
            int Calificacion_2 = 0;
            int Calificacion_3 = 0;
            decimal promedio = 0;

            try
            {
                Console.WriteLine("Digite la Calificacion #1");
                Calificacion_1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la Calificacion #2");
                Calificacion_2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la Calificacion #3");
                Calificacion_3 = Convert.ToInt32(Console.ReadLine());

                promedio = (Calificacion_1 + Calificacion_2 + Calificacion_3) / 3;

                Console.WriteLine($"El Promedio de las Clasificaciones es: {promedio}.");

                if (promedio >= 7)
                {
                    Console.WriteLine("Promocionado!");
                }
                else
                {
                    Console.WriteLine("Reprobado!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Datos invalidos. {ex.Message}");
            }
 
        
        }


    }
}
