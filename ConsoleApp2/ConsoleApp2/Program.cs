using ConsoleApp2.Clases.ArbolBinarioOrdenado;
using ConsoleApp2.Clases.JuegoAnimal;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {


        //NUMERO DE NODOS
        public static int numNodos(Nodo raiz)
        {
            if (raiz == null)
            {
                return 0;
            }
            else
            {
                return 1 + numNodos(raiz.subarbolIzquierdo())
                        + numNodos(raiz.subarbolDerecho());
            }
        }

        /// RECORRIDOS DE LOS NODOS
        public static void preorden(Nodo r)
        {
            if (r != null)
            {
                r.visitar();
                preorden(r.subarbolIzquierdo());
                preorden(r.subarbolDerecho());
            }
        }

        // Recorrido de un árbol binario en inorden
        public static void inorden(Nodo r)
        {
            if (r != null)
            {
                inorden(r.subarbolIzquierdo());
                r.visitar();
                inorden(r.subarbolDerecho());
            }
        }

        // Recorrido de un árbol binario en postorden
        public static void postorden(Nodo r)
        {
            if (r != null)
            {
                postorden(r.subarbolIzquierdo());
                postorden(r.subarbolDerecho());
                r.visitar();
            }
        }

        static void juegoAnimales()
        {
            Console.WriteLine("Juguemos a adivinar animales");
            Boolean otroJuego = true;
            AdivinaAnimal juego = new AdivinaAnimal();

            do
            {
                juego.jugar();
                Console.WriteLine("Jugamos otra vez?");
                otroJuego = juego.respuesta();
            } while (otroJuego);
        }

        public static void prueba_arbol_normal()
        {
            try
            {
                // TODO code application logic here
                ArbolBinario arbol;
                Nodo a1, a2, a;
                Stack pila = new Stack();
                a1 = ArbolBinario.nuevoArbol(null, "Maria", null);
                a2 = ArbolBinario.nuevoArbol(null, "Fabrizio", null);
                a = ArbolBinario.nuevoArbol(a1, "Gaby", a2);
                pila.Push(a);
                a1 = ArbolBinario.nuevoArbol(null, "Andrea", null);
                a2 = ArbolBinario.nuevoArbol(null, "Abel", null);
                a = ArbolBinario.nuevoArbol(a1, "Monica", a2);
                pila.Push(a); // apilamos
                //desapilamos las ramas
                a2 = (Nodo)pila.Pop(); //desapilamos
                a1 = (Nodo)pila.Pop();


                a = ArbolBinario.nuevoArbol(a1, "Hector", a2);
                arbol = new ArbolBinario(a);

                Console.WriteLine("Preorden:");
                preorden(a);

                Console.WriteLine("inorden:");
                inorden(a);


                Console.WriteLine("postorden:");
                postorden(a);

                // pausa para debug
                int pausa;
                pausa = 0;


            }
            catch (Exception ex)
            {
                Console.WriteLine("Ups error " + ex.Message);
            }
        }

        public static void pruebaOrden()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            int[] datos = { 30, 5, 2, 40, 36, 85 };
            SoloNumeros es = new SoloNumeros();
            foreach (int d in datos)
            {
                es.numero = d;
                es.descripcion = $"insertar No.{d}";
                ArBus.insertar(es);
                es = new SoloNumeros();
            }
            int pausa;
            pausa = 0;
            es = new SoloNumeros();
            es.numero = 36;
            es.descripcion = "cualquier cosa";
            ArBus.eliminar(es);
            pausa = 0;

        }

        public static void ordenCarnet()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            List<Estudiante> estudiantes = new List<Estudiante>();
            estudiantes.Add(new Estudiante(26309, "Kerinson"));
            estudiantes.Add(new Estudiante(45623, "Winiverto"));
            estudiantes.Add(new Estudiante(45832, "Carrillo"));
            estudiantes.Add(new Estudiante(12432, "Lenin"));
            Estudiante estudiante = new Estudiante();
            foreach(var d in estudiantes)
            {
                estudiante.numMat = d.numMat;
                estudiante.nombre = d.nombre;
                ArBus.insertar(estudiante);
                estudiante = new Estudiante();
            }
            int pausa;
            pausa = 0;

        }
       



        static void Main(string[] args)
        {
            // prueba_arbol_normal();
            // juegoAnimales();
            //pruebaOrden();
            ordenCarnet();


        }
    }
}
