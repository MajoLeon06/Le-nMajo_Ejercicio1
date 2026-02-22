Console.WriteLine("TIPO DE ATENCIÓN");
Console.WriteLine(" 1: Emergencia");
Console.WriteLine(" 2: Consulta");
Console.WriteLine(" 3: Pediatría");
Console.WriteLine(" 4: Traumatología");
Console.WriteLine("Ingresar opción: ");
int option = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar temperatura:");
double temperatura = double.Parse(Console.ReadLine());
Console.WriteLine("Ingresar saturación de oxígeno:");
double saturacion = double.Parse(Console.ReadLine());
Console.WriteLine("Ingresar nivel de dolor (0-10)");
int dolor = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar presión sistólica");
double presion = double.Parse(Console.ReadLine());
Console.WriteLine("Ingresar edad:");
double edad = double.Parse(Console.ReadLine());
if (edad>0 && presion>0 && (dolor>=0 && dolor<=10) && saturacion>0 && temperatura>0)
{
    switch(option)
    {
        case 1:
            {
                if (saturacion<90)
                {
                    Console.WriteLine("Prioridad 1");
                    Console.WriteLine("Poner oxígeno");
                }
                else if (temperatura>=39 && dolor>=8)
                {
                    Console.WriteLine("Prioridad 2");
                    Console.WriteLine("Realizar exámenes");
                }
                else if (edad>=50 && dolor>=8 && saturacion<80)
                {
                    Console.WriteLine("Atención inmediata");
                }
                else { 
                    Console.WriteLine("Prioridad 3");
                    Console.WriteLine("Consulta normal");
                }
                break;
            }
    }
}