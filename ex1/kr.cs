using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr
{
    class Program
    {
        struct computer
        {
            public struct electro_pristriy 
            {
                public string interfase;
                public int potuznist;
                public float vaga;

                public void el_display()
                {
                    Console.WriteLine($"Interface is {interfase}");
                    Console.WriteLine($"Power is {potuznist} Amper");
                    Console.WriteLine($"Weight is {vaga} kg");
                }
            }

            public struct pristriy_info
            {
                public float led_diagonal;
                public int led_resolution_x;
                public int led_resolution_y;
                public float led_price;

                public void led_display()
                {
                    Console.WriteLine("_____________");
                    Console.WriteLine($"Monior:\nDiagonal: {led_diagonal}");
                    Console.WriteLine($"Resolution {led_resolution_x}x{led_resolution_y}");
                    Console.WriteLine($"Price: {led_price}$");
                }
            }
        }

        static void Main(string[] args)
        {
            computer.electro_pristriy epu;
            epu.interfase = "Android OS";
            epu.potuznist = 2100;
            epu.vaga = 1.5f;
            epu.el_display();

            computer.pristriy_info led;
            led.led_diagonal = 7.1f;
            led.led_resolution_x = 700;
            led.led_resolution_y = 1200;
            led.led_price = 99.99f;
            led.led_display();

            Console.ReadKey();
        }
    }
}