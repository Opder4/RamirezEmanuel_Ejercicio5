Console.WriteLine("Ingrese el tipo de solicitante: ");
Console.WriteLine("");
Console.WriteLine("1. Empleado fijo");
Console.WriteLine("2. Temporal");
Console.WriteLine("3. Independiente");
Console.WriteLine("4. Estudiante");
Console.WriteLine("");
int solicitante=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el salario mensual: ");
Console.WriteLine("");
double salario=double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la antigüedad laboral (meses): ");
Console.WriteLine("");
int meses=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el monto solicitado: ");
Console.WriteLine("");
Console.WriteLine("Ingrese el Historial crediticio: ");
Console.WriteLine("");
Console.WriteLine("1. Excelente");
Console.WriteLine("2. Bueno");
Console.WriteLine("3. Regular");
Console.WriteLine("4. Malo");
Console.WriteLine("");
int historialcrediticio=int.Parse(Console.ReadLine());
Console.WriteLine("");
double montosolicitado=double.Parse(Console.ReadLine());
Console.WriteLine("");
bool fiador = false;
if  (solicitante==1 || historialcrediticio==4)
{
    fiador = true;
}
if (salario>=0 && meses>=0 && montosolicitado>=0 && historialcrediticio>=1 && historialcrediticio<=4)
{
    switch (solicitante)
    {
        case 1:

            break;
        case 2:

            break;
        case 3:

            break;
            case 4:

            break;
        default:
            Console.WriteLine("Solicitante no válido");
            break;
    }
}
else
{
    Console.WriteLine("Datos ingresados no válidos");
}