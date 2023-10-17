L'application permet à la bibliothèque de répertorier les livres proposés celle-ci.
Le test technique front-end est composé de 5 bogues à corriger ainsi que 3 fonctionnalités à implémenter.

# Bogue 1

Lorsque l'utilisateur ouvre la liste des livres, la mention "Chargement..." n'apparait pas alors qu'elle devrait pourtant apparaitre!

# Bogue 2

Les utilisateurs ne sont présentement incapables de créer un livre ! La page de création devrait normalement apparaitre lorsque l'on clique sur le livre avec un "+".

# Bogue 3

Malgré que le bouton est grisé, l'utilisateur est en mesure de créer un livre alors qu'il n'est pas valide (`BookCreateView.vue`). Il peut également enregister des modifications sans quelles soient valides (`BookUpdateView.vue`). Il faut empêcher l'utilisateur de soumettre lorsque des données ne sont pas valides.

# Bogue 4

**Lorsque l'utilisateur charge directement la page de création de livre** (`http://localhost:5173/book/create`), sans passer par la liste, l'utilisateur est capable d'entrer un id existant et le bouton s'active malgré tout. Il faut corriger la validation pour empêcher l'utilisation d'identifiant existant dans ce cas.

# Bogue 5

À des fins de déboggage, un `console.log` est présent dans `BookCreateView.vue`. En temps normal, un log devrait apparaitre à chaque fois qu'une modification est effectuée. Par exemple, entrer le titre "Livre" devrait engendrer l'écriture de 5 lignes dans la console. Il faut corriger le problème afin qu'un `console.log` soit effectué à chaque fois qu'une modification est apportée au livre.

---

# Fonctionnalité 1

Il n'est présentement pas possible de supprimer un livre. Il faut donc implémenter la suppression de livre à même la liste des livres.

# Fonctionnalité 2

Les utilisateurs aimeraient être en mesure d'avoir un champ recherche afin de leur permettre de chercher un livre par son titre ou son auteur.

# Fonctionnalité 3

Les utilisateurs aimeraient pouvoir ordonner les livres en ordre alphabétique. L'utilisateur doit également être en mesure de mettre les livres en ordre anti-alphabétique.
