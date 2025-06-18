Sub CreateProjectPresentation()

    ' Declare PowerPoint objects
    Dim pptApp As Object
    Dim pptPres As Object
    Dim pptSlide As Object
    Dim pptShape As Object
    Dim pptTextBox As Object
    Dim i As Integer

    ' Create a new PowerPoint application
    On Error Resume Next
    Set pptApp = GetObject(, "PowerPoint.Application")
    If Err.Number <> 0 Then
        Set pptApp = CreateObject("PowerPoint.Application")
    End If
    On Error GoTo 0

    pptApp.Visible = True

    ' Create a new presentation
    Set pptPres = pptApp.Presentations.Add

    ' Slide 1: Title Slide
    Set pptSlide = pptPres.Slides.Add(1, 1) ' ppLayoutTitle
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "[TITRE DU DOCUMENT]" ' [cite: 1]
    Set pptShape = pptSlide.Shapes.AddTextbox(1, 100, 200, 500, 100) ' msoTextOrientationHorizontal, Left, Top, Width, Height
    pptShape.TextFrame.TextRange.Text = "[Sous-titre du document]" & _
                                       "[DATE]" & _
                                       "[NOM DE LA SOCIETE]" & _
                                       "[Adresse de la société]" ' [cite: 1]
    pptShape.TextFrame.TextRange.Font.Size = 18

    ' Slide 2: Introduction
    Set pptSlide = pptPres.Slides.Add(2, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Introduction"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Objectif Principal du Projet:" & _
                      "- Développer une application web de commande de nourriture en ligne. [cite: 3]" & _
                      "- Clients: Parcourir menu, recherches, passer commandes. [cite: 3, 4]" & _
                      "- Administrateurs: Gérer catégories, plats, commandes; visualiser statistiques. [cite: 5, 6]" & _
                      "- Finalité: Automatiser commandes, réduire erreurs, améliorer expérience client et gestion interne. [cite: 6, 7]" & _
                      "Problématique et Solution Proposée:" & _
                      "- Problématique: Systèmes de commande non optimisés (téléphone, papier) entraînant erreurs et gestion chronophage. [cite: 7, 8]" & _
                      "- Solution: Plateforme centralisée (Front-end clients, Back-office gérants). [cite: 9]" & _
                      "Public Cible:" & _
                      "- Clients: Particuliers souhaitant commander en ligne. [cite: 10]" & _
                      "- Admin: Propriétaires de restaurants ou staff. [cite: 11]"

    ' Slide 3: Technologies Utilisées
    Set pptSlide = pptPres.Slides.Add(3, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Technologies Utilisées"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Frontend:" & _
                      "- HTML5, CSS3, PHP (pour le dynamisme). [cite: 11]" & _
                      "Backend:" & _
                      "- PHP, MySQL. [cite: 12]" & _
                      "Outils:" & _
                      "- XAMPP (serveur local), phpMyAdmin (gestion BDD). [cite: 12]"

    ' Slide 4: Fonctionnalités Clés
    Set pptSlide = pptPres.Slides.Add(4, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Fonctionnalités Clés"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Côté Client:" & _
                      "- Menu par catégories. [cite: 13]" & _
                      "- Recherche dynamique. [cite: 13]" & _
                      "- Passer une commande. [cite: 13]" & _
                      "- Interface responsive. [cite: 13]" & _
                      "Côté Admin:" & _
                      "- Gestion des plats (CRUD). [cite: 13]" & _
                      "- Suivi des commandes. [cite: 13]" & _
                      "- Tableau de bord statistique. [cite: 13]" & _
                      "- Authentification sécurisée. [cite: 13]"

    ' Slide 5: Structure de la Base de Données
    Set pptSlide = pptPres.Slides.Add(5, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Structure de la Base de Données"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Tables Principales:" & _
                      "- tbl_food (plats). [cite: 15]" & _
                      "- tbl_category (catégories). [cite: 15]" & _
                      "- tbl_order (commandes). [cite: 16]" & _
                      "- tbl_admin (comptes admin). [cite: 16]"

    ' Slide 6: Aperçu Côté Client (Frontend)
    Set pptSlide = pptPres.Slides.Add(6, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Aperçu Côté Client (Frontend)"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Page d'Accueil (index.php):" & _
                      "- Barre de recherche intégrée. [cite: 17]" & _
                      "- Affiche les catégories populaires et les plats mis en avant. [cite: 17]" & _
                      "Passer une Commande (order.php):" & _
                      "- Sélection du plat + quantité. [cite: 21]" & _
                      "- Formulaire de livraison (Nom, téléphone, adresse, email). [cite: 21]" & _
                      "- Calcul automatique du total. [cite: 21]" & _
                      "- Confirmation visuelle après commande. [cite: 22]"

    ' Slide 7: Aperçu Côté Administration (Backend)
    Set pptSlide = pptPres.Slides.Add(7, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Aperçu Côté Administration (Backend)"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Gestion des Comptes Admins:" & _
                      "- Connexion sécurisée (login.php). [cite: 25]" & _
                      "- CRUD des Admins (manage-admin.php). [cite: 25]" & _
                      "Gestion du Menu:" & _
                      "- Catégories (manage-category.php): Ajout/suppression avec upload d'image. [cite: 26, 27]" & _
                      "- Plats (manage-food.php): Liaison avec catégories, gestion prix, image, statut. [cite: 27, 28]" & _
                      "Gestion des Commandes (manage-order.php):" & _
                      "- Liste complète des commandes avec filtres (Statuts: En attente, Livré, Annulé). [cite: 28, 29]" & _
                      "- Mise à jour manuelle du statut. [cite: 29]" & _
                      "Tableau de Bord (index.php):" & _
                      "- Statistiques: Nombre de catégories, plats, commandes. [cite: 29, 38]" & _
                      "- Revenus totaux (somme des commandes livrées). [cite: 30, 39]"

    ' Slide 8: Conception Visuelle (Aperçu)
    Set pptSlide = pptPres.Slides.Add(8, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Conception Visuelle (Aperçu)"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Logo Concept:" & _
                      "- Minimaliste: fourchette et couteau en forme de ""F"". [cite: 45]" & _
                      "- Palette de couleurs: #FF6B6B (Rouge/Orange), #4ECDC4 (Turquoise). [cite: 46]" & _
                      "- Typographie: Poppins. [cite: 46]" & _
                      "Maquettes (Exemple: Page d'Accueil Desktop):" & _
                      "- Header fixe avec logo + menu. [cite: 48]" & _
                      "- Section héros avec recherche. [cite: 48]" & _
                      "- Grille de catégories (3 colonnes). [cite: 49]" & _
                      "- Liste des plats populaires (6 items). [cite: 49]" & _
                      "' (User to insert image of mockup if available from source [cite: 47])"

    ' Slide 9: Analyse et Conception (UML)
    Set pptSlide = pptPres.Slides.Add(9, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Analyse et Conception (UML)"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Diagramme de Cas d’utilisation:" & _
                      "- Rôles: Recueillir, analyser, organiser les besoins et fonctionnalités. [cite: 69]" & _
                      "- Acteurs: [cite: 70, 71, 72, 73, 74]" & _
                      "  - Visiteur: Recherche produits/infos. [cite: 70, 71]" & _
                      "  - Client: Compte créé, passe commandes, gère panier. [cite: 72]" & _
                      "  - Administrateur (Webmaster): Gère dynamisme du site, mise à jour produits, prix, disponibilités. [cite: 73, 74]" & _
                      "Diagramme de Classes:" & _
                      "- Outil pour modéliser la structure interne (entités, attributs, méthodes, relations). [cite: 74, 75]" & _
                      "- Classes Clés: [cite: 76, 77, 78, 79, 80]" & _
                      "  - Admin: Gestion catégories, plats, commandes. [cite: 76]" & _
                      "  - Client: Inscription, connexion, commandes. [cite: 77]" & _
                      "  - Category: Catégorie d’aliments. [cite: 78]" & _
                      "  - Food: Plat avec caractéristiques. [cite: 79]" & _
                      "  - Order: Informations des commandes. [cite: 80]" & _
                      "- Relations: Ex: Un admin gère plusieurs catégories; une catégorie contient plusieurs plats. [cite: 81, 82, 83, 84]"

    ' Slide 10: Installation (Résumé)
    Set pptSlide = pptPres.Slides.Add(10, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Installation (Résumé)"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Prérequis:" & _
                      "- XAMPP (Apache + MySQL + PHP). [cite: 113]" & _
                      "- PHP 7.4+, MySQL 5.7+. [cite: 113]" & _
                      "Étapes d’Installation:" & _
                      "1. Installation de XAMPP (Apache, MySQL, PHP cochés). [cite: 114, 115]" & _
                      "2. Copier les fichiers du projet dans C:\xampp\htdocs\food-order (Windows) ou /opt/lampp/htdocs/food-order (Linux/macOS). [cite: 118]" & _
                      "3. Créer la base de données via http://localhost/phpmyadmin et importer le schéma food-order.sql. [cite: 119]" & _
                      "Lancer l’Application:" & _
                      "- Frontend: http://localhost/food-order [cite: 121]" & _
                      "- Backend Admin: http://localhost/food-order/admin (admin/password). [cite: 121]"

    ' Slide 11: Résultats et Performances
    Set pptSlide = pptPres.Slides.Add(11, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Résultats et Performances"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Fonctionnalités Réalisées:" & _
                      "- Frontend (100% complété): Catalogue, recherche, commande, responsive. [cite: 124]" & _
                      "- Backend (100% complété): CRUD (Admins, Catégories, Produits), tableau de bord, gestion commandes. [cite: 124, 125]" & _
                      "- Base de Données: 4 tables optimisées. [cite: 125]" & _
                      "- Performance: Temps de chargement moyen 1.2s (GTmetrix), capacité 50 commandes simultanées. [cite: 125]" & _
                      "Difficultés Rencontrées et Solutions Apportées: [cite: 125, 126]" & _
                      "- Upload d'images (>2MB): Modif php.ini (upload_max_filesize), vérif JS. [cite: 125, 126]" & _
                      "- Injection SQL potentielle: Implémentation requêtes préparées. [cite: 125, 126]" & _
                      "- Sessions admin instables: Timeout configuré. [cite: 125, 126]" & _
                      "- Compatibilité mobile (Safari iOS): Correction viewport, Media queries. [cite: 125, 126]"

    ' Slide 12: Sécurité et Optimisation
    Set pptSlide = pptPres.Slides.Add(12, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Sécurité et Optimisation"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Mesures de Sécurité:" & _
                      "- Protection Injections SQL: Requêtes préparées avec mysqli_stmt. [cite: 127]" & _
                      "- Authentification Admin Renforcée: Hachage (password_hash()), sessions (timeout 30min, regen ID). [cite: 128, 129]" & _
                      "- Sécurité des Uploads: Vérif type/taille, renommage aléatoire. [cite: 130, 131]" & _
                      "- Protection CSRF: Jetons uniques. [cite: 131]" & _
                      "Optimisations Possibles/Réalisées:" & _
                      "- Performance BDD: Ajout d’index. [cite: 131]" & _
                      "- Optimisation Frontend: Compression images (WebP). [cite: 132]" & _
                      "- Pagination des Résultats: Réduction temps chargement. [cite: 133]"

    ' Slide 13: Perspectives d’Amélioration
    Set pptSlide = pptPres.Slides.Add(13, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Perspectives d’Amélioration"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Évolutions Futures:" & _
                      "- Paiement en Ligne (Stripe/PayPal). [cite: 135, 136]" & _
                      "- Système de Livraison en Temps Réel (Géolocalisation, Suivi). [cite: 137, 138]" & _
                      "- Espace Client (Comptes Utilisateurs, Historique, Favoris). [cite: 138, 139]" & _
                      "- Système d’Avis et Notes. [cite: 139, 140]" & _
                      "Recommandations:" & _
                      "- Sécurité Renforcée: HTTPS (certificat SSL), Double authentification (2FA) admins. [cite: 141, 142]" & _
                      "- Performance: CDN pour images, Compression GZIP, Lazy-load. [cite: 143, 144]" & _
                      "- Expérience Utilisateur (UX): Recherche avancée, Dark mode, Chatbot. [cite: 144, 145]" & _
                      "- Maintenance: Sauvegardes BDD automatisées, MàJ dépendances. [cite: 146, 147]"

    ' Slide 14: Conclusion
    Set pptSlide = pptPres.Slides.Add(14, 2) ' ppLayoutText
    pptSlide.Shapes.Title.TextFrame.TextRange.Text = "Conclusion"
    Set pptTextBox = pptSlide.Shapes.Placeholders(2).TextFrame.TextRange
    pptTextBox.Text = "Ce projet a permis de développer un système de gestion de commandes pour restaurants avec PHP et MySQL. [cite: 148, 149]" & _
                      "La plateforme modernise la prise de commandes via une interface en ligne automatisée et un back-office de gestion. [cite: 149]" & _
                      "Le système est responsive et conçu de manière modulaire (partials) pour une maintenance simplifiée. [cite: 150, 151]" & _
                      "La BDD (tbl_order, tbl_food, tbl_admin) est scalable et des mesures de sécurité (sessions, hachage MDP) ont été implémentées. [cite: 152, 153]" & _
                      "Ce projet de fin d’études démontre une maîtrise des concepts fondamentaux du développement web. [cite: 154]" & _
                      "Il constitue une base solide pour des extensions futures (paiements, API mobile, notifications). [cite: 155]" & _
                      "L'objectif de créer une solution dynamique, sécurisée et intuitive a été atteint. [cite: 156, 157]"

    ' Clean up
    Set pptTextBox = Nothing
    Set pptShape = Nothing
    Set pptSlide = Nothing
    Set pptPres = Nothing
    Set pptApp = Nothing

    MsgBox "Présentation PowerPoint créée avec succès!", vbInformation

End Sub