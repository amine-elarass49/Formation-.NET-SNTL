namespace DemoLinQ;
public class EtudiantService
{

    public List<Etudiant> ToList()
    {
        List<Etudiant> etudiants = new List<Etudiant>
        {
            new Etudiant { Id = 1, Nom = "Ahmed", Note = 12, Ville = "Casablanca", _idGroup = 1 },
            new Etudiant { Id = 2, Nom = "Mohamed", Note = 15, Ville = "Rabat", _idGroup = 1 },
            new Etudiant { Id = 3, Nom = "Fatima", Note = 10, Ville = "Tanger", _idGroup = 2 },
            new Etudiant { Id = 4, Nom = "Hassan", Note = 8, Ville = "Casablanca", _idGroup = 2 },
            new Etudiant { Id = 5, Nom = "Karim", Note = 16, Ville = "Rabat", _idGroup = 3 },
            new Etudiant { Id = 6, Nom = "Salma", Note = 18, Ville = "Tanger", _idGroup = 3 },
            new Etudiant { Id = 7, Nom = "Nadia", Note = 9, Ville = "Casablanca", _idGroup = 4 },
            new Etudiant { Id = 8, Nom = "Omar", Note = 11, Ville = "Rabat", _idGroup = 4 },
            new Etudiant { Id = 9, Nom = "Sara", Note = 7, Ville = "Tanger", _idGroup = 5 },
            new Etudiant { Id = 10, Nom = "Ali", Note = 3, Ville = "Casablanca", _idGroup = 5 }
        };
        return etudiants;
    }

}