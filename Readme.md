# Test Technique Groupe Shift v1.0.0
# Introduction

Bienvenue à l'entrevue technique de Groupe Shift.

Ce document vous guidera à travers les questions de l'entrevue technique. Le but de cet entretien est d'évaluer vos compétences techniques et votre capacité à résoudre différents problèmes que nous résolvons habituellement dans notre travail quotidien. Gardez à l’esprit qu’il n’est pas nécessaire de résoudre tous les problèmes et que vous devez viser la qualité plutôt que la quantité.

Vous devez également garder à l’esprit que l’intervieweur est là pour vous aider et que vous ne devez pas hésiter à demander de l’aide si vous êtes bloqué. **Chaque question est accompagnée d'une suggestion de temps**. Si vous êtes bloqué sur une question, vous devez demander de l'aide à l'intervieweur. Cela garantira que vous disposerez de suffisamment de temps pour terminer le reste de l'interview.

Notez que vous pouvez utiliser **Google, StackOverflow, ChatGPT, etc.** pour vous aider à résoudre les problèmes. Vous pouvez également demander de l'aide à l'intervieweur si vous êtes bloqué. De plus, il est fortement conseillé de laisser des commentaires dans votre code lorsque vous le jugez nécessaire. Les commentaires peuvent aussi être utilisé afin d'**expliquer votre raisonnement si vous n'arrivez pas à résoudre un problème.**

## Table des matières

1. [Introduction](#introduction)
2. [Préparation](#préparation)
   1. [Étape 1 : Cloner le code à partir du répertoire git.](#étape-1--cloner-le-code-à-partir-du-répertoire-git)
   2. [Étape 2 : Compiler l'application backend en utilisant dotnet 7.](#étape-2--compiler-lapplication-backend-en-utilisant-dotnet-7)
   3. [Étape 3 : Installer les dépendances et démarrer le frontend.](#étape-3--installer-les-dépendances-et-démarrer-le-frontend)
3. [Test technique backend](#test-technique-backend)
   1. [🐞 Bogues backend à corriger](#🐞-bogues-backend-à-corriger)
      1. [Bogue 1 : La liste des membres ne retourne pas l'ensemble des membres.](#bogue-1--la-liste-des-membres-ne-retourne-pas-lensemble-des-membres)
      2. [Bogue 2 : L'application plante lorsque j'essaie de supprimer un livre.](#bogue-2--lapplication-plante-lorsque-jessaie-de-supprimer-un-livre)
   2. [🥳 Fonctionnalités backend à implémenter](#🥳-fonctionnalités-backend-à-implémenter)
      1. [Fonctionnalité 1 : En tant qu'utilisateur, je souhaite que la liste des livres soit triée par titre par ordre alphabétique par défaut.](#fonctionnalité-1--en-tant-quutilisateur-je-souhaite-que-la-liste-des-livres-soit-triée-par-titre-par-ordre-alphabétique-par-défaut)
      2. [Fonctionnalité 2 : En tant qu'utilisateur, je souhaite que les membres soient uniques en fonction de leurs e-mails.](#fonctionnalité-2--en-tant-quutilisateur-je-souhaite-que-les-membres-soient-uniques-en-fonction-de-leurs-e-mails)
      3. [Fonctionnalité 3 : En tant qu'utilisateur, je souhaite voir si un livre est disponible ou non.](#fonctionnalité-3--en-tant-quutilisateur-je-souhaite-voir-si-un-livre-est-disponible-ou-non)
4. [Test technique frontend](#test-technique-frontend)
   1. [🐞 Bogues frontend à corriger](#🐞-bogues-frontend-à-corriger)
      1. [Bogue 1 : La liste n'affiche pas de chargement](#bogue-1--la-liste-naffiche-pas-de-chargement)
      2. [Bogue 2 : Les utilisateurs sont incapable de créer un livre.](#bogue-2--les-utilisateurs-sont-incapable-de-créer-un-livre)
      3. [Bogue 3 : La réactivité du livre est dysfonctionnelle.](#bogue-3--la-réactivité-du-livre-est-dysfonctionnelle)
   2. [🥳 Fonctionnalités frontend à implémenter](#🥳-fonctionnalités-frontend-à-implémenter)
      1. [Fonctionnalité 1 : En tant qu'utilisateur, j'aimerais pouvoir supprimer un livre.](#fonctionnalité-1--en-tant-quutilisateur-jaimerais-pouvoir-supprimer-un-livre)
      2. [Fonctionnalité 2 : En tant qu'utilisateur, j'aimerais pouvoir chercher un livre.](#fonctionnalité-2--en-tant-quutilisateur-jaimerais-pouvoir-chercher-un-livre)
      3. [Fonctionnalité 3 : En tant qu'utilisateur, j'aimerais pouvoir ordonner les livres.](#fonctionnalité-3--en-tant-quutilisateur-jaimerais-pouvoir-ordonner-les-livres)

# Préparation

## Étape 1 : Cloner le code à partir du répertoire git.

**Description :** La première étape de l'entrevue technique consiste à obtenir le code source à partir du répertoir. Vous devriez déjà être sur le répertoire publique, vous pouvez utiliser le client Git de votre choix avec lequel vous souhaitez cloner le répertoire. Vous pouvez également télécharger directement le code source depuis le répertoire.

> **🕥 Suggestion de temps :** 10 minutes

## Étape 2 : Compiler l'application backend.

**Description :** Il faut désormais compiler l'API backend à l'aide de dotnet 7. En utilisant l'outil de votre choix, vous devriez pouvoir compiler l'API backend. L'API backend se trouve dans le dossier `backend`, vous pouvez l'ouvrir à l'aide du fichier `tech-interview.sln`. Vous devriez pouvoir compiler la solution et l’exécuter à partir de là.

> **💡 Conseil :** L'exécution de l'application doit la démarrer sur le port 5008 sur l'interface Swagger UI qui vous permettra de tester l'API, l'url est `http://localhost:5008/swagger/index.html`.

> **🕥 Suggestion de temps :** 10 minutes

## Étape 3 : Installer les dépendances et démarrer le frontend.

**Description :** La troisième étape consiste à installer les dépendances du frontend à l'aide de `npm i` (Node.js est requis). Vous pouvez ensuite démarrer l'application frontend en utilisant `npm run dev` et vous rendre à l'addresse `http://localhost:5173/`.

> **💡 Conseil :** Si vous avez **peu d'expérience avec Vue** ou que vous n'avez **jamais utilisé le [Composition API](https://vuejs.org/guide/extras/composition-api-faq.html#what-is-composition-api)**, nous suggérons fortement l'utilisation de [Visual Studio Code](https://code.visualstudio.com/) ainsi que des extensions suivantes:
>
> - [Volar](https://marketplace.visualstudio.com/items?itemName=Vue.volar)
> - [TypeScript Vue Plugin (Volar)](https://marketplace.visualstudio.com/items?itemName=Vue.vscode-typescript-vue-plugin).

> **🕥 Suggestion de temps :** 10 minutes

---

C'est parti ! Vous disposez d'environ **60 à 90 minutes** pour résoudre les problèmes. Comme mentionné dans l'introduction, vous devez viser à résoudre ceux que vous comprenez bien et vous concentrer sur la qualité plutôt que sur la quantité. Les différents problèmes et exigences sont répertoriés ci-dessous, ils vont du plus simple au plus difficile.

Bonne chance ! 🎉

# Test technique backend

Le backend est élaboré à l'aide d'une structure "Clean architecture" très simplifiée. Si vous n'avez jamais travaillé avec le Clean architecture ou que vous avez besoin d'information supplémentaire, utilisez [la documentation suivante](./docs/Backend.md). Comme mentionné plus haut, vous devrez, tout au long des tests backend utiliser l'interface Swagger UI qui vous permettra de tester l'API, l'url est `http://localhost:5008/swagger/index.html`.

Swagger vous permet de tester les différents points de terminaison de l'API. Vous pouvez également utiliser Postman ou tout autre outil de votre choix au besoin. Si vous avez des questions sur cette partie, n'hésitez surtout pas à demander à l'intervieweur.

## 🐞 Bogues backend à corriger

### Bogue 1 : La liste des membres ne retourne pas l'ensemble des membres.

**Description :** Lorsqu'on utilise l'API la liste des membres n'est pas complète, elle devrait cependant retourner tous les membres de l'application, **sans exception**.

> **🕥 Suggestion de temps :** 5 minutes

### Bogue 2 : L'application plante lorsque j'essaie de modifier un membre.

**Description :** Lorsque l'on utilise l'API afin de modifier le membre yanick.rondeau@groupeshift.ca ayant l'id `100` afin de corriger son courriel pour yannick.rondeau@groupeshift.ca, l'application retourne une erreur.

> **🕥 Suggestion de temps :** 10 minutes

## 🥳 Fonctionnalités backend à implémenter

### Fonctionnalité 1 : En tant qu'utilisateur, je souhaite que la liste des livres soit triée par titre par ordre alphabétique par défaut.

**Description:** L'utilisateur nous a demandé s'il serait possible de trier automatiquement la liste des livres par titre et par ordre alphabétique. L'utilisateur aimerait avoir cette fonctionnalité par défaut, cela l'aiderait à trouver un livre plus rapidement et ce serait plus convivial.

> **🕥 Suggestion de temps :** 10 minutes

### Fonctionnalité 2 : En tant qu'utilisateur, je souhaite que les membres soient uniques en fonction de leurs e-mails.

**Description:** L'utilisateur nous a demandé s'il serait possible de garantir que les membres sont uniques en fonction de leurs e-mails. Cela empêcherait l'utilisateur d'ajouter un membre avec une adresse e-mail qui existe déjà et éviterait des problèmes avec les prêts.

> **🕥 Suggestion de temps :** 20 minutes

### Fonctionnalité 3 : En tant qu'utilisateur, je souhaite voir si un livre est disponible ou non.

**Description:** L'utilisateur nous a demandé s'il serait possible de voir si un livre est disponible ou non. Un livre est disponible lorsqu’aucun prêt n’y est associé. L'utilisateur souhaite voir ces informations dans la liste des livres et dans les détails du livre.

> **🕥 Suggestion de temps :** 30 minutes

# Test technique frontend

Le projet frontend est élaboré à l'aide de [Vue 3](https://vuejs.org/guide/introduction.html), [TailwindCSS](https://tailwindcss.com/docs/installation) et [Pinia](https://pinia.vuejs.org/introduction.html). [Tel que mentionné précédemment](#étape-3--installer-les-dépendances-et-démarrer-le-frontend), l'utilisation de Visual Studio Code est suggéré mais n'est pas obligatoire.

## 🐞 Bogues frontend à corriger

### Bogue 1 : La liste n'affiche pas de chargement.

**Description :** Lorsque l'utilisateur ouvre la liste des livres, la mention "Chargement..." n'apparait pas alors qu'elle devrait pourtant apparaitre !

> **🕥 Suggestion de temps :** 5 minutes

### Bogue 2 : Les utilisateurs sont incapable de créer un livre.

**Description :** Les utilisateurs sont présentement incapables de créer un livre ! La page de création devrait normalement apparaitre lorsque l'on clique sur le livre avec un "+".

> **🕥 Suggestion de temps :** 5 minutes

### Bogue 3 : La réactivité du livre est dysfonctionnelle.

**Description :** À des fins de déboggage, un `console.log` est présent dans `BookCreateView.vue`. En temps normal, un "log" devrait apparaitre dans la console du navigateur à chaque fois qu'une modification est effectuée sur le livre. Par exemple, entrer le titre "Livre" devrait engendrer l'écriture de 5 lignes dans la console mais ça ne semble pas être le cas. Il faut corriger le problème afin qu'un `console.log` soit effectué à chaque fois qu'une modification est apportée au livre.

> **🕥 Suggestion de temps :** 5 minutes

## 🥳 Fonctionnalités frontend à implémenter

### Fonctionnalité 1 : En tant qu'utilisateur, j'aimerais pouvoir supprimer un livre.

**Description :** Il n'est présentement pas possible de supprimer un livre. Il faut donc implémenter la suppression de livre à même la liste des livres.

> **🕥 Suggestion de temps :** 10 minutes

### Fonctionnalité 2 : En tant qu'utilisateur, j'aimerais pouvoir chercher un livre.

**Description :** Les utilisateurs aimeraient être en mesure d'avoir un champ recherche afin de leur permettre de chercher un livre par son titre ou son auteur.

> **🕥 Suggestion de temps :** 10 minutes

### Fonctionnalité 3 : En tant qu'utilisateur, j'aimerais pouvoir ordonner les livres.

**Description :** Les utilisateurs aimeraient pouvoir ordonner les livres en ordre alphabétique. Ils doivent également être en mesure de mettre les livres en ordre anti-alphabétique.

> **🕥 Suggestion de temps :** 10 minutes

# Questions ouvertes

1. Pouvez-vous citer quelques améliorations que vous aimeriez voir dans cette application ?
1. Pouvez-vous énumérer certains des problèmes que vous avez rencontrés dans cette application ?
