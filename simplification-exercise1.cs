double GetPaymentAmount()
{
	if (_isDead) 
		return GetDeadAmount();
	if (_isSeparated) 
		return GetSeparatedAmount();
	if (_isRetired) 
		return GetRetiredAmount();
			
	return GetNormalPayAmount();
	
};
