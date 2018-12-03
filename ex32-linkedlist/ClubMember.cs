namespace ex32_linkedlist
{
	public class ClubMember
	{
		private int alder;
		private string fNavn;
		private string lNavn;
		private int nr;
		public ClubMember(int nr, string Fname, string Lname, int alder)
		{
			Nr = nr;
			FNavn = Fname;
			LNavn = Lname;
			Alder = alder;
		}

		public int Alder { get { return alder; } set { alder = value; } }
		public string FNavn { get { return fNavn; } set { fNavn = value; } }
		public string LNavn { get { return lNavn; } set { lNavn = value; } }
		public int Nr { get { return nr; } set { nr = value; } }
		public override string ToString()
		{
			return $"{Nr} {FNavn} {LNavn} {Alder}";
		}
	}
}