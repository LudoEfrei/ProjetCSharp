# ProjetCSharp - Gestion	d'une	agence	de	travail	intérimaire

Le	 but	 de	 	 ce	 projet	 est	 de	 réaliser	 la	 gestion	 d'une	 agence	 de	 travail	 intérimaire	 qui	 place	 des	
employés	en	mission	 suite	 à	 des	 commandes	 faites	 par	 des	entreprises clientes ayant	 des	 besoins	
ponctuels.

Votre application	va	gérer	:

- Un	pool	d'entreprises	clientes
Chaque	entreprise	cliente	est	définie	par	son	nom,	son	adresse, son	n°	de	Siret	ainsi	qu'un	contact	
(personne	qui	effectue	les	commandes	de	missions	pour	cette	entreprise)

- Un	pool	d'intérimaires	à	placer	en	mission
Chaque	intérimaire	est	défini	par	son	nom,	son	prénom,	son	age,	un	ensemble	de	compétences	(à	
vous	de	le	modéliser),	un	tarif	journalier	(qui	peut	être	un	fixe	ou	variable,	auquel	cas	l'employé	
touchera	une	commission	en	fonction	du	chiffre	d'affaires	qu'il	génère	chez	le	client)

- Un	système	de	facturation	des	missions
Une	facture	est	adressée	au	contact	de	l'entreprise	cliente,		cette	facture	récapitule	la	mission	
effectuée	par	un	employé	intérimaire	au	sein	de	cette	entreprise	cliente

- Un	système	de	prise	de	commandes	de	mission	pour	les	entreprises	clientes
Une	mission	consiste	à	placer	un	employé	pour	une	durée	donnée	par	une	date	de	début	de	mission	
et	une	date	de	fin	de	mission	auprès	d'une	entreprise	cliente.

- Un	système	de	suivi	de	suivi	des	missions	
L’employé doit	 saisir	quotidiennement l’avancement	de	la	mission à	l’aide	d’une	fiche	de	suivie.	Les	
informations	d’avancement	concernant :
• un	pourcentage	d’avancement de	la	mission.
• Un	pourcentage	précisant	le	risque	que	la	mission	ne	sera	pas	finie	avant	la	date	fin.	
