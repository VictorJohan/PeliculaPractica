using Microsoft.EntityFrameworkCore;
using RegistroPeliculas.DAL;
using RegistroPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroPeliculas.BLL
{
    public class PeliculasBLL
    {
        public static bool Guardar(Peliculas pelicula)
        {
            if (!Existe(pelicula.IdPelicula))
            {
                return Insertar(pelicula);
            }
            else
            {
                return Modificar(pelicula);
            }
        }

        public static bool Existe(int id)
        {
            bool ok = false;
            Contexto contexto = new Contexto();

            try
            {
                ok = contexto.Peliculas.Any(e => e.IdPelicula == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ok;
        }

        private static bool Insertar(Peliculas pelicula)
        {
            Contexto contexto = new Contexto();
            bool ok = false;

            try
            {
                contexto.Peliculas.Add(pelicula);
                ok = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        private static bool Modificar(Peliculas pelicula)
        {
            Contexto contexto = new Contexto();
            bool ok = false;

            try
            {
                contexto.Entry(pelicula).State = EntityState.Modified;
                ok = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ok;
        }

        public static Peliculas Buscar(int id)
        {
            Peliculas peliculas;
            Contexto contexto = new Contexto();

            try
            {
                peliculas = contexto.Peliculas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }

            return peliculas;
        }

        public static bool Eliminar(int id)
        {
            bool ok = false;
            Peliculas pelicula;
            Contexto contexto = new Contexto();

            try
            {
                pelicula = contexto.Peliculas.Find(id);
                if(pelicula != null)
                {
                    contexto.Peliculas.Remove(pelicula);
                    ok = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ok;
        }
    }
}
