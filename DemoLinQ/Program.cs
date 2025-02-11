// See https://aka.ms/new-console-template for more information
using DemoLinQ;

//Console.WriteLine("Hello, World!");


 var etudiantService = new EtudiantService();
// var listESup10 = new List<Etudiant>();

// foreach (var item in etudiantService.ToList()){
//     if(item.Note >= 10){
//         listESup10.Add(item);
//     }
// }

// foreach (var item in listESup10){
//     Console.WriteLine("Etudiant "+ item.Nom + ", note:" + item.Note);
// }

// Methode par Syntaxe de requete
var etudiantLinQSynReQSup10 = (from e in etudiantService.ToList()
                        where e.Note >= 10
                        select e).ToList();

// Methode par Syntaxe de requete
var etudiantLinQMethodeSup10 = etudiantService.ToList()
                                    .Where(e => e.Note >= 10)
                                    .OrderBy(e1 => e1.Ville)
                                    .ToList();


// etudiantLinQSynReQSup10.ForEach(e => Console.WriteLine("Nom: " + e.Nom + ", note: " + e.Note));
etudiantLinQMethodeSup10.ForEach(e => Console.WriteLine("Nom: " + e.Nom + ", note: " + e.Note));
