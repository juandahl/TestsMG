

isWhite(row, column){
	//odd row and odd column 
	if ( (row % 2 === 1) && (column % 2 === 1) )
		return false;
	//even row and odd column
	if ( (row % 2 === 0) && (column % 2 === 1) )
		return true; 
	//odd row and even column
	if ( (row % 2 === 1) && (column % 2 === 0) )
		return true; 
	//even row and even column
	if ( (row % 2 === 0) && (column % 2 === 0) )
		return false; 
 
}