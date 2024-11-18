<h1>Kalorësi në Shah: BFS dhe DFS</h1>
Ky repository përmban dy implementime të algoritmeve për gjetjen e rrugës më të shkurtër për kalorësin në shah në një tabelë 8x8. Përdoren dy metoda kërkimi: Breadth-First Search (BFS) dhe Depth-First Search (DFS).

BFS (Breadth-First Search): Ky algoritëm kërkon rrugën më të shkurtër për kalorësin, duke eksploruar të gjitha mundësitë në mënyrë të barabartë dhe pa shpenzuar shumë kohë, duke siguruar një rrugë optimale.

DFS (Depth-First Search): Ky algoritëm eksploron degët e mundshme të tabelës duke shkuar sa më thellë që të jetë e mundur, duke përdorur një strategji të thellimit të kërkimit. 

Të dyja metodat përdorin një tabelë 8x8 dhe lëvizjet e zakonshme të kalorësit në shah (në drejtimet diagonale). Programi lejon përdoruesit të fusë pozitat fillestare dhe destinacionin dhe më pas përcakton rrugën e mundshme për të kaluar nga njëra pikë në tjetrën.

<h5>Përdorimi:</h5>

Përdoruesi fut pozitat fillestare dhe destinacionin.
Programi përdor BFS ose DFS për të kërkuar rrugën dhe e shfaq atë.
Nëse rruga është gjetur, do të shfaqet numri i lëvizjeve dhe rruga e plotë; përndryshe, do të tregojë një mesazh që nuk ka rrugë të mundshme.
