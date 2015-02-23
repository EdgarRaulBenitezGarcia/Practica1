namespace Practica{
	
class practica1
{
   public static void Main(string[] args)
    {
        int opc=0,valor1=0,valor2=0,resp=0;
        double valor3,valor4,resp1;
        const double PI= 3.14;
        
        System.Console.WriteLine("Bienvenido seleciona lo que deseas hacer");
        System.Console.WriteLine("[1] suma");
        System.Console.WriteLine("[2] resta");
        System.Console.WriteLine("[3] multiplicacion");
        System.Console.WriteLine("[4] division");
        System.Console.WriteLine("[5] area triangulo");
        System.Console.WriteLine("[6] area circulo");
        System.Console.WriteLine("[7] area cuadrado");
        System.Console.WriteLine("");
        opc = int.Parse(System.Console.ReadLine());
        switch(opc){
            case 1:
                System.Console.WriteLine("suma");
                System.Console.WriteLine("Ingresa un primer valor");
                valor1 = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Ingresa un segundo valor");
                valor2 = int.Parse(System.Console.ReadLine());
                resp = valor1+valor2;
                
                break;
             case 2:
                System.Console.WriteLine("resta");
                System.Console.WriteLine("Ingresa un primer valor");
                valor1 = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Ingresa un segundo valor");
                valor2 = int.Parse(System.Console.ReadLine());
                resp = valor1-valor2;
                break;
                
              case 3:
                System.Console.WriteLine("multiplicacion");
                System.Console.WriteLine("Ingresa un primer valor");
                valor1 = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Ingresa un segundo valor");
                valor2 = int.Parse(System.Console.ReadLine());
                resp = valor1*valor2;
                break;
              case 4:
                System.Console.WriteLine("Division");
                System.Console.WriteLine("Ingresa un primer valor");
                valor3 = float.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Ingresa un segundo valor");
                valor4 = float.Parse(System.Console.ReadLine());
                resp1 = valor3/valor4;
                break;
              case 5:
                System.Console.WriteLine("Area Triangulo");
                System.Console.WriteLine("Ingresa base");
                valor3 = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Ingresa circulo");
                valor4 = int.Parse(System.Console.ReadLine());
                resp1 = (valor3*valor4)/2;
                break;
              case 6:
                System.Console.WriteLine("Area circulo");
                System.Console.WriteLine("Ingresa el Radio (R)");
                valor3 = int.Parse(System.Console.ReadLine());
                resp1 = PI*valor3;
                resp1 = resp1*resp1;                
                break;
              case 7:
              System.Console.WriteLine("Area Cuadrado");
                System.Console.WriteLine("Ingresa un lado (L)");
                valor3 = int.Parse(System.Console.ReadLine());
                resp1 = valor3*valor3;
                break;  
                  
                
                
        
        
        
        }
    }}}