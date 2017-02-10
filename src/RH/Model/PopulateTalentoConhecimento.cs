using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinRH;

public static class PopulateTalentoConhecimento
{
    /// <summary>
    /// Gera Lista de Conhecimentos necessários
    /// </summary>
    /// <param name="talento"></param>
    public static void Populate(this Talento talento)
    {
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Ionic", Nota = 0, IsImportante = true });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Android", Nota = 0, IsImportante = true });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "IOS", Nota = 0, IsImportante = true });

        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "HTML", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "CSS", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Bootstrap", Nota = 0, IsImportante = true });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Jquery", Nota = 0, IsImportante = true });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "AngularJs", Nota = 0, IsImportante = true });

        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Java", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Asp.Net MVC", Nota = 0, IsImportante = true });

        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "C", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "C++", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Cake", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Django", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Majento", Nota = 0 });

        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "PHP", Nota = 0, IsImportante = true });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Wordpress", Nota = 0, IsImportante = true });

        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Phyton", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Ruby", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "MySQL Server", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "MySQL", Nota = 0 });

        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Salesforce", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Photoshop", Nota = 0 });
        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "Illustrator", Nota = 0 });

        talento.Conhecimento.Add(new Conhecimento() { Talento = talento, Nome = "SEO", Nota = 0 });




    }
}
