using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>   // bana bir tip ver dedi ordaki T=type demek, ona göre aşağıyı yapılandıracak o. O an programcı ne verdiyse tipi o olsun demek.
    {
        T[] items;
        
        //constructor "ctor" yaz tabtab
        public MyList()
        {
            items = new T[0];  //bellekte yer edinmek için new lemememiz gerekiyor. bunu da burda yapıyoruz.Bu çalışan bloğa constructor denir.
        }
        
        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizinin referansı items'ın referansı oldu. Length'i arttırdığımızda elemanlarımız kaybolmasın diye geçiciye verdik şimdilik.
            items = new T[items.Length + 1]; //dizinin eleman sayısını 1 arttır.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];            //temparray içindekileri de alalım.
            }

            items[items.Length - 1] = item;  //artık son elemanı da ekleyebiliriz ADD içindeki item2 ekledik.
        }
    }
}
