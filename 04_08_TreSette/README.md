### Ereditarietà
Creare due classi che permettano di giocare con CARTE DA GIOCO tresette (40 carte)

- La Classe Carte:
ha le seguenti campi privati e proprietà pubbliche: seme, valore
Il Valore può essere: Asso,2,3,4,5,6,7, Fante, Regina, Re
Il Seme può avere i seguenti valori: Cuore, Picche, Fiore, Quadri
Il controllo sui vincoli di integrità deve essere fatto nella sezione set creando eccezioni in
caso di dati errati
contiene i seguenti metodi:
Metodo privato Proponi() deve essere “estratta” una carta con seme e valore casuale
mediante due metodi privati e dovrà essere restituita una stringa con “Seme” , “Valore”.

- La classe MazzoCarte
contiene come proprietà privata un numero progressivo ed una lista in cui poter caricare tutte
le carte del mazzo.
I metodi pubblici sono:
InserisciCarta(obj) che permette di inserire una nuova istanza carta nella lista se non
ancora presente.
due Metodi DammiCarta (con gli opportuni parametri) che restituiscano:
  - la prima carta del mazzo;
  - la carta con il seme e il valore richiesto se presente;
MescolaCarte() che riordina le istanze del mazzo in sequenza casuale
(Suggerimento: usare un vettore di appoggio per:
    1) inserire in modo casuale gli elementi della lista
    2) ricopiare le istanze dal vettore nella lista iniziale).

Le classi vanno opportunamente commentate e devono essere adeguatamente gestiti gli errori .
Dovrà essere creata una semplice interfaccia che permetta di richiamare i metodi richiesti.