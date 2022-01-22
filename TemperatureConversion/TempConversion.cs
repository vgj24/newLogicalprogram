using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 #!/bin/bash

read choice
if [ $choice -eq 1 ]
then    echo -n "Enter temoreture (c) : "
        read tc
        #formula Tf=(9/5)*Tc+32
        tf=$(echo "scale=2;((9/5)*$tc) + 32")
        echo "tc c = $tf F"
elif [ $choice -eq 2 ]
then
        echo -n "Enter tempreture (f) : "
        read tf
        #formula Tc=(5/9*(Tf-32)
        echo "$tf = $tc"
else
        echo "please select 1 or 2 only" */


namespace TemperatureConversion
{
    internal class TempConversion
    {
        public TempConversion()
        {
            Console.WriteLine("1.convert celsius tempreture into fahrenheit");
            Console.WriteLine("2. convert fahrenheit tempretures into celcuius");
            Console.WriteLine("select your choice (1-2) : ");
            int choice= int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Console.WriteLine("enter temperature");
                double tempincelcious= double.Parse(Console.ReadLine());
                double tempinfaranite =(tempincelcious*(9/5))+32;
                Console.WriteLine("Temperature in faranhite is :"+tempinfaranite);
            }
            else if(choice==2)
            {
                Console.WriteLine("enter temperature ");
                double tempinfaranite2=double.Parse(Console.ReadLine());
                double tempincelcious2 = (tempinfaranite2 - 32) * (5 / 9);
                Console.WriteLine("Temperature in Celcious is :"+tempincelcious2);
            }
            else
            {
                Console.WriteLine("please select 1 or 2 only");
            }
        }

    }
}
