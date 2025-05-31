namespace Bau.Libraries.LibDataStructures.Tools.Comparers;

/// <summary>
///		Comparador de <see cref="Base.BaseModel"/>
/// </summary>
internal class BaseModelComparer : AbstractBaseComparer<Base.BaseModel>
{
	internal BaseModelComparer(bool ascending) : base(ascending) { }

	/// <summary>
	///		Compara dos elementos por Id
	/// </summary>
	protected override int CompareData(Base.BaseModel first, Base.BaseModel second) => (first.Id ?? 0).CompareTo(second.Id ?? 0);
}