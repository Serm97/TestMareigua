using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMareigua
{
    public class Task1
    {
        //Contructor
        public Task1(){}
        public void Print100Numbers(){
            
            for(int i = 0; i <= 100; i++){

                if((i % 3 == 0) && (i % 5 == 0)){
                    Console.WriteLine("mareigua");
                    continue;
                }

                if((i % 3 == 0)){
                    Console.WriteLine("mare");
                    continue;
                }

                if((i % 5 == 0)){
                    Console.WriteLine("mare");
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
