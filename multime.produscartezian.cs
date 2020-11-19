

class pair 
{
	
	element a;
	element b;
	
	public pair(element pa, element pb)
	{
		a = pa;
		b = pb;
		
	}

	
}

class multimepairs 
{
	List <pair> perechi = new List<pair>();
}

void produscartezian(ref multime B, ref multimepairs pc)
{
	
	for(int i = 0 ; i< elemente.Length; i++)
	{
		for(int j = 0 ; j< B.elemente.Length; j++)
		{
			pc.element.Add(new pair(elemente[i],B.elemente[j]));
		}		
		
	}
	
	
}