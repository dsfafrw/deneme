using System;
using System.Collections.Generic;
using System.Text;

namespace demo2
{
    
    class BasvuruManager
    {
        public void basvuruYap(IKrediManager krediManager)
        {
            krediManager.hesapla();
        }
    }
}
