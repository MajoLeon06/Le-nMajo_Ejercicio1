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
        case 2:
            {
                if (edad < 18)
                {
                    Console.WriteLine("Referir a pediatría");
                }
                else
                    {
                    Console.WriteLine("Consulta normal");
                }
                break;
            }
        case 3:
            {
                if (edad<12 && temperatura>=38)
                {
                    Console.WriteLine("Prioridad 1");
                    Console.WriteLine("Consulta urgente");
                }
                else if (saturacion<90)
                {
                    Console.WriteLine("Prioridad 1, considerado emergencia");
                }
                else if (dolor>=8)
                {
                    Console.WriteLine("Prioridad 2");
                    Console.WriteLine("Consulta");
                }
                else
                {
                    Console.WriteLine("Consulta normal");
                }
                break;
            }
        case 4:
            {
                Console.WriteLine("Realizar radiografía");
                Console.WriteLine("¿Anormalidad encontrada? 1:Si 2:No");
                int sino = int.Parse(Console.ReadLine());
                if (dolor>=8 && sino==1)
                {
                    Console.WriteLine("Prioridad 1");
                    Console.WriteLine("Consulta urgente");
                    Console.WriteLine("Fractura");
                }
                else if (dolor<=8 && sino==1)
                {
                    Console.WriteLine("Prioridad 2");
                    Console.WriteLine("Consulta");
                    Console.WriteLine("Posible fractura");
                }
                else if (dolor<8 && sino==2)
                {
                    Console.WriteLine("Prioridad 3");
                    Console.WriteLine("Consulta");
                    Console.WriteLine("Observación");
                }
                break;
            }
        default:
            {
                Console.WriteLine("Ingrese opción nuevamente");
                break;
            }
    }
}
else
{
    Console.WriteLine("Datos no válidos");
}