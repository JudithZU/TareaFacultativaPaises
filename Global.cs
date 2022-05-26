using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPaises
{
    class Global
    {
        public static List<Continente> Continentes = new List<Continente>()
        {
            new Continente(1,"AFRICA")
            ,new Continente(2,"AMERICA")
            ,new Continente(3,"ASIA")
            ,new Continente(4,"EUROPA")
        };

        public static List<Pais> Paises = new List<Pais>()
        {
            new Pais(1,"AO","AGO","Angola","Luanda",244,1)
            , new Pais(2,"DZ","DZA","Argelia","Algiers",213,1)
            , new Pais(3,"BJ","BEN","Benín","Porto Novo",229,1)
            , new Pais(4,"BW","BWA","Botsuana","Gaborone",267,1)
            , new Pais(5,"BF","BFA","Burkina Faso","Ouagadougou",226,1)
            , new Pais(6,"BI","BDI","Burundi","Bujumbura",257,1)
            , new Pais(7,"CV","CPV","Cabo Verde","Praia",238,1)
            , new Pais(8,"AI","AIA","Anguila","The Valley",1264,2)
            , new Pais(9,"AR","ARG","Argentina","Buenos Aires",54,2)
            , new Pais(10,"AW","ABW","Aruba","Oranjestad",297,2)
            , new Pais(11,"BS","BHS","Bahamas","Nassau",1,2)
            , new Pais(12,"BB","BRB","Barbados","Bridgetown",1,2)
            , new Pais(13,"BZ","BLZ","Belice","Belmopan",501,2)
            , new Pais(14,"BM","BMU","Bermudas","Hamilton",1,2)
            , new Pais(15,"AF","AFG","Afganistán","Kabul",93,3)
            , new Pais(16,"SA","SAU","Arabia Saudita","Riyadh",966,3)
            , new Pais(17,"AM","ARM","Armenia","Yerevan",374,3)
            , new Pais(18,"AZ","AZE","Azerbaiyán","Baku",994,3)
            , new Pais(19,"BH","BHR","Bahréin","Manama",973, 3)
            , new Pais(20,"BD","BGD","Bangladesh","Dhaka",880,3)
            , new Pais(21,"MM","MMR","Birmania(Myanmar)","Nay Pyi Taw",95,3)
            , new Pais(22,"AL","ALB","Albania","Tirana",355,4)
            , new Pais(23,"DE","DEU","Alemania","Berlin",49,4)
            , new Pais(24,"AD","AND","Andorra","Andorra la Vella",376,4)
            , new Pais(25,"AT","AUT","Austria","Vienna",43,4)
            , new Pais(26,"BE","BEL","Bélgica","Brussels",32,4)
        };
    }
    public class Continente
    {
        int id;
        string nombrecontinente;

        public Continente(int id, string nombrecontinente)
        {
            this.Id = id;
            this.Nombrecontinente = nombrecontinente;
        }

        public int Id { get => id; set => id = value; }
        public string Nombrecontinente { get => nombrecontinente; set => nombrecontinente = value; }
    }
    public class Pais
    {
        int id;
        string codigo1;
        string codigo2;
        string nombrepais;
        string nombrecapital;
        int prefijo;
        int idContinente;
        //Constructor
        public Pais(int id, string codigo1, string codigo2, string nombrepais, string nombrecapital, int prefijo, int idContinente)
        {
            this.Id = id;
            this.Codigo1 = codigo1;
            this.Codigo2 = codigo2;
            this.Nombrepais = nombrepais;
            this.Nombrecapital = nombrecapital;
            this.Prefijo = prefijo;
            this.IdContinente = idContinente;
        }
        //Propiedades
        public int Id { get => id; set => id = value; }
        public string Codigo1 { get => codigo1; set => codigo1 = value; }
        public string Codigo2 { get => codigo2; set => codigo2 = value; }
        public string Nombrepais { get => nombrepais; set => nombrepais = value; }
        public string Nombrecapital { get => nombrecapital; set => nombrecapital = value; }
        public int Prefijo { get => prefijo; set => prefijo = value; }
        public int IdContinente { get => idContinente; set => idContinente = value; }
    }
}