Console.WriteLine("Ingrese el tipo de solicitante: ");
Console.WriteLine("");
Console.WriteLine("1. Empleado fijo");
Console.WriteLine("2. Temporal");
Console.WriteLine("3. Independiente");
Console.WriteLine("4. Estudiante");
Console.WriteLine("");
int solicitante=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el salario mensual (Q): ");
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
            if (historialcrediticio==1)
            {
                if (salario>=1000 && meses>=6)
                {
                    Console.WriteLine("Estado: Aprobado");
                    Console.WriteLine("Razón: Cumple con los requisitos");
                }
                else if (salario>=1000 || meses>=6)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: No cumple con todos los requisitos ideales");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else if (historialcrediticio==2)
            {
                if (salario >= 1500 && meses >= 12)
                {
                    Console.WriteLine("Estado: Aprobado");
                    Console.WriteLine("Razón: Cumple con los requisitos");
                }
                else if (salario >= 1500 || meses >= 12)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: No cumple con todos los requisitos ideales");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else if (historialcrediticio==3)
            {
                if (salario >= 3000 && meses >= 18)
                {
                    Console.WriteLine("Estado: Aprobado");
                    Console.WriteLine("Razón: Cumple con los requisitos");
                }
                else if (salario >= 3000 || meses >= 18)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: No cumple con todos los requisitos ideales");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else if (historialcrediticio==4)
            {
                if (fiador && montosolicitado<1000)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: Tiene un mal historial crediticio.");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
                break;
        case 2:
            if (historialcrediticio == 1)
            {
                if (salario >= 1000 && meses >= 2)
                {
                    Console.WriteLine("Estado: Aprobado");
                    Console.WriteLine("Razón: Cumple con los requisitos");
                }
                else if (salario >= 1000 || meses >= 2)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: No cumple con todos los requisitos ideales");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else if (historialcrediticio == 2)
            {
                if (salario >= 1500 && meses >= 4)
                {
                    Console.WriteLine("Estado: Aprobado");
                    Console.WriteLine("Razón: Cumple con los requisitos");
                }
                else if (salario >= 1500 || meses >= 4)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: No cumple con todos los requisitos ideales");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else if (historialcrediticio == 3)
            {
                if (salario >= 3000 && meses >= 6)
                {
                    Console.WriteLine("Estado: Aprobado");
                    Console.WriteLine("Razón: Cumple con los requisitos");
                }
                else if (salario >= 3000 || meses >= 6)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: No cumple con todos los requisitos ideales");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else if (historialcrediticio == 4)
            {
                if (fiador && montosolicitado < 1000)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: Tiene un mal historial crediticio.");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            break;
        case 3:
            if (historialcrediticio == 1)
            {
                if (salario >= 2000 && meses >= 6)
                {
                    Console.WriteLine("Estado: Aprobado");
                    Console.WriteLine("Razón: Cumple con los requisitos");
                }
                else if (salario >= 2000 || meses >= 6)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: No cumple con todos los requisitos ideales");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else if (historialcrediticio == 2)
            {
                if (salario >= 3000 && meses >= 12)
                {
                    Console.WriteLine("Estado: Aprobado");
                    Console.WriteLine("Razón: Cumple con los requisitos");
                }
                else if (salario >= 3000 || meses >= 12)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: No cumple con todos los requisitos ideales");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else if (historialcrediticio == 3)
            {
                if (salario >= 6000 && meses >= 18)
                {
                    Console.WriteLine("Estado: Aprobado");
                    Console.WriteLine("Razón: Cumple con los requisitos");
                }
                else if (salario >= 6000 || meses >= 18)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: No cumple con todos los requisitos ideales");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else if (historialcrediticio == 4)
            {
                if (fiador && montosolicitado < 1000)
                {
                    Console.WriteLine("Estado: Aprobado con condición");
                    Console.WriteLine("Razón: Tiene un mal historial crediticio.");
                }
                else
                {
                    Console.WriteLine("Estado: Rechazado");
                    Console.WriteLine("Razón: No cumple con ningun requisito");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            break;
        case 4:
            if (fiador)
            {
                Console.WriteLine("Estado: Aprobado");
                Console.WriteLine("Razón: Cumple con los requisitos");
                Console.WriteLine("Su fiador se encargará de lo demás");
            }
            else
            {
                Console.WriteLine("Estado: Rechazado");
                Console.WriteLine("Razón: No cumple con ningun requisito");
            }
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
Console.WriteLine("");