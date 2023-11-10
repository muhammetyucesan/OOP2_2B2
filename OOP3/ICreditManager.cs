using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager // baş kısmı interface yaptık. class sildik ortadan ve CreditManager başına I koyduk, okunabilirliği arttırmak için ve interface olduğunu kolay anlarız.
    {
        // public kısmını da void Calculate in basından kaldırıyoruz. ortak imza
        void Calculate();
      // { } parantezleri kaldırıyoruz ortak imza oldugu için void Calculate kısmı. 
       void DoMove(); 
    }
}
