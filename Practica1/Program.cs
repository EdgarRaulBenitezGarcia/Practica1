namespace Practica{
	
class practica1
{ public int SUMA(int x,int y){
		int z;
		z=x+y;
		return z;
	}
	
	public int RESTA(int x,int y){
		int z;
		z=x-y;
		return z;
	}
	public int MULTIPLICACION(int x,int y){
		int z;
		z=x*y;
		return z;
	}
	
	public double MULTIPLICACION(double x,double y){
		double z;
		z=x*y;
		return z;
	}
	
	
	public double DIVISION (double x,double y){
		double z;
		z=x/y;
		return z;
	}
	
	public void LIMPIAR(){
	 System.Console.ReadLine();
     System.Console.Clear();
	}
  
   public static void Main(string[] args)
    {
        int opc=0,valor1=0,valor2=0,resp=0;
        double valor3,valor4,resp1;
        const double PI= 3.14;
        const double tri=2;
        practica1 prac = new practica1();
        do{
        System.Console.WriteLine("Bienvenido seleciona lo que deseas hacer");
        System.Console.WriteLine("[1] suma");
        System.Console.WriteLine("[2] resta");
        System.Console.WriteLine("[3] multiplicacion");
        System.Console.WriteLine("[4] division");
        System.Console.WriteLine("[5] area triangulo");
        System.Console.WriteLine("[6] area circulo");
        System.Console.WriteLine("[7] area cuadrado");
        System.Console.WriteLine("[0] salir");
        System.Console.WriteLine("");
        opc = int.Parse(System.Console.ReadLine());
        switch(opc){
            case 1:
                System.Console.WriteLine("suma");
                System.Console.WriteLine("Ingresa un primer valor");
                valor1 = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Ingresa un segundo valor");
                valor2 = int.Parse(System.Console.ReadLine());
                resp = prac.SUMA(valor1,valor2);
                System.Console.WriteLine("la suma es de {0}",resp);
                prac.LIMPIAR();
                break;
             case 2:
                System.Console.WriteLine("resta");
                System.Console.WriteLine("Ingresa un primer valor");
                valor1 = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Ingresa un segundo valor");
                valor2 = int.Parse(System.Console.ReadLine());
                resp = prac.RESTA(valor1,valor2);
                System.Console.WriteLine("la resta es de {0}",resp);
                prac.LIMPIAR();
                break;
                
              case 3:
                System.Console.WriteLine("multiplicacion");
                System.Console.WriteLine("Ingresa un primer valor");
                valor1 = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Ingresa un segundo valor");
                valor2 = int.Parse(System.Console.ReadLine());
                resp = prac.MULTIPLICACION(valor1,valor2);
                System.Console.WriteLine("la multiplicacion es de {0}",resp);
                prac.LIMPIAR();
                break;
              case 4:
                System.Console.WriteLine("Division");
                System.Console.WriteLine("Ingresa un primer valor");
                valor3 = double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Ingresa un segundo valor");
                valor4 = double.Parse(System.Console.ReadLine());
                resp1 = prac.DIVISION(valor3,valor4);
                System.Console.WriteLine("la division es de {0}",resp1);
                prac.LIMPIAR();
                break;
              case 5:
                System.Console.WriteLine("Area Triangulo");
                System.Console.WriteLine("Ingresa base");
                valor3 = double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Ingresa altura");
                valor4 = double.Parse(System.Console.ReadLine());
                resp1 = prac.MULTIPLICACION(valor3,valor4);
                resp1 = prac.DIVISION(resp1,tri);
                System.Console.WriteLine("el area de el triangulo con base {0} y altura {1} es de {2}",valor3,valor4,resp1);
                prac.LIMPIAR();
                break;
              case 6:
                System.Console.WriteLine("Area circulo");
                System.Console.WriteLine("Ingresa el Radio (R)");
                valor3 = double.Parse(System.Console.ReadLine());
                resp1 = prac.MULTIPLICACION(valor3,valor3);
                resp1 = prac.MULTIPLICACION(resp1,PI);
                System.Console.WriteLine("el area del circulo con radio {0} es de {1}",valor3,resp1);
                prac.LIMPIAR();
                
                break;
              case 7:
              System.Console.WriteLine("Area Cuadrado");
                System.Console.WriteLine("Ingresa un lado (L)");
                valor1 = int.Parse(System.Console.ReadLine());
                resp = prac.MULTIPLICACION(valor1,valor1);
                System.Console.WriteLine("el area del cuadrado es de {0}",resp);
                prac.LIMPIAR();
                break;  
                  
                
                
        
        
        
        }}while(opc!=0);
        System.Console.WriteLine("saliendo enter para salir");
       System.Console.Read();
    }}}