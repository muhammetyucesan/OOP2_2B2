using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;


        //constructor : ctor tab yapınca cıkıyor.
        public MyList()
        {
                items = new T[0]; // array ı sıfırlamış olduk. nice.d //dizimiz 0 elemanlı?
        }

        public void Add(T item)   // T çalıştığımız tip. örn: string gibi. burada da string oluyor. Program.cs de öyle ayarladıkçünkü.
        {
            T[] tempArray = items; // geçici dizi kullandık dizideki elemanlar kaybolmasın diye. new yaptıgımız icin adres değişiyor çünkü. bu adresi bu diziye tutturuyoruz elemanları için.
            items = new T[items.Length + 1]; 

            for (int i = 0; i < tempArray.Length; i++) // tempArray ın tuttugu elemanlarla birleştiriyoruz. 
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = item; // son eleman item[n-1] ,n uzunlugu dizinşn o yüzden -1
        }

    }
}
