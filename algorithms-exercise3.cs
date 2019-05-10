double ApplesByFences(int fences){
	//2^0 = 1 apple for himself
	//2^1 = 2 apples for the first guard
	//2^2 = 4 apples for the second guard
	//...
	int result = 0;
	for (int i=0; i <= fences; i++)
		result += Math.Pow(2,i);
	return result;
}
