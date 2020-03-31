using System;
using MtgApiManager.Lib.Service;
using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Dto;

namespace MTGCardOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            CardService service = new CardService();
            var result = service.All();
            System.Console.WriteLine(result.ToString());

            // CardService service = new CardService();
            // Exceptional<List<Card>> result = service.All();
            // if (result.IsSuccess)
            // {
            //     var value = result.Value;
            // }
            // else
            // {
            //     var exception = result.Exception;
            // }
        }
    }
}
