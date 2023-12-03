To make the project work , you should change your string connection in appsettings.json file.

**TP1** :

1. **Modification de la Route dans MovieController.cs**:

Dans le fichier MovieController.cs, ajustez la route pour inclure l'URL Movie/released/2020/03 pour l'action ByRelease, avec les arguments (month, year), afin de renvoyer simplement un contenu.

2.  **Exécution et Gestion de l'Erreur 404**:

Lorsqu'on accède à l'URL Movie/released/2020/03, une erreur 404 se produit, indiquant que la route n'est pas définie. Pour résoudre cela, il est nécessaire d'ajouter la route dans le fichier Program.cs. Les éventualités rencontrées comprennent :

Mapper la route dans le fichier Program.cs avec le contrôleur et l'action correspondante.
Respecter l'ordre des routes dans le fichier Program.cs.

3.**Systèmes de Routage ASP.Net**:

Convention-based Routing:

-Système de routage par défaut.
-Basé sur le nom du contrôleur et le nom de l'action.
-Configuré dans le fichier Program.cs.

-Attribute Routing:
*Basé sur les attributs.
*Configuré au niveau du contrôleur.
-Custom Routing:
\*Basé sur une classe qui implémente l'interface IRouter.

4-Passer Deux Modèles (Movie et Customer) à la Vue:

Ajoutez une classe Customer (Id, Name).
Passez à la vue un film et une liste de clients en utilisant un ViewModel.
Liste (statique) les enregistrements au niveau du contrôleur et retournez le ViewModel.
Modifiez le modèle assigné à la vue.
Récupérez les détails du client par son Id.
