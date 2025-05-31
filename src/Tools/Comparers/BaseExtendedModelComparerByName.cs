namespace Bau.Libraries.LibDataStructures.Tools.Comparers;

/// <summary>
///		Comparador de <see cref="Base.BaseExtendedModel"/>
/// </summary>
internal class BaseExtendedModelComparerByName : AbstractBaseComparer<Base.BaseExtendedModel>
{
	internal BaseExtendedModelComparerByName(bool ascending) : base(ascending) { }

	/// <summary>
	///		Compara dos elementos por nombre
	/// </summary>
	protected override int CompareData(Base.BaseExtendedModel first, Base.BaseExtendedModel second)
	{
		return (first.Name ?? string.Empty).CompareTo(second.Name ?? string.Empty);
	}
}