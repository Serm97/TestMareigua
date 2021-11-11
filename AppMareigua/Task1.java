public class Task1 {
    public static void main(String args[]) {

      /* 3.Cree un programa que sea capaz de escribir los números del 1 al 100. 
        *Si un número es múltiplo de 3, se escribe “mare” en su lugar. 
        *Si el número es múltiplo de 5, se escribe “igua”. 
        *Si el número es múltiplo de ambos se escribe “mareigua”.
       */

        System.out.println("Cree un programa que sea capaz de escribir los números del 1 al 100. \n\n");

        for(int i = 0; i <= 100; i++){
          
          if((i % 3 == 0) && (i % 5 == 0)){
              System.out.println("mareigua");
              continue;
          }
          
          if((i % 3 == 0)){
              System.out.println("mare");
              continue;
          }
          
          if((i % 5 == 0)){
              System.out.println("mare");
              continue;
          }
          
          System.out.println(i);
        }
    }
}