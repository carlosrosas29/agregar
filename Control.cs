using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaCarros
{
    class carro
    {
        inicio[] car = new inicio[15];
        public int i = 0;
        public int t = 14;
        int cuantosHay = 0;
        string find = "";
        public void agregar(inicio datos)
        {
            car[cuantosHay] = datos;
            cuantosHay++;
        }
        public inicio buscar(string placas)
        {
           // string data;
            for (int b = 0; b < cuantosHay; b++)
            {
                if (car[b].pla == placas)
                {
                    return car[b];
                }
                car[b] = find;
            }
            return ;
        }
        public void eliminar(string placa)
        {
            for (int e = 0; e <cuantosHay; e++)
            {
                if (car[e].pla == placa)
                {
                    car[e] = car[e + 1];


                    car[cuantosHay - 1] = null;
                    cuantosHay--;
                }
            }
        }
        public void insertar(inicio data, int po)
        {
            for (int i = 0; i <= t; i++)
            {
                car[po] = car[po + 1];
                car[po] = data;
            }
            i++;
        }

        public string listar()
        {
            string mostrar = " ";
            for (int m = 0; m < cuantosHay; m++)
            {
                mostrar += "[" + m + "] = " + car[m].pla + Environment.NewLine + car[m].mar + Environment.NewLine + car[m].mo + Environment.NewLine + car[m].tel + Environment.NewLine + car[m].ano + Environment.NewLine; 
            }
            return mostrar;
        }
    }
}
