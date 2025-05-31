namespace Bau.Libraries.LibDataStructures.Collections;

/// <summary>
///		Colección con una serie de datos limitada a n elementos
/// </summary>
public class QueueLimited<TypeData> where TypeData : class
{
	public QueueLimited(int maxItems = 10)
	{
		MaxItems = maxItems;
	}

	/// <summary>
	///		Añade un elemento
	/// </summary>
	public void Add(TypeData item)
	{
		// Quita el elemento si estaba en la lista
		Remove(item);
		// Añade el elemento
		Items.Add(item);
		// Quita el primer elemento si se ha llegado al límite
		if (Items.Count > MaxItems)
			Items.RemoveAt(0);
	}

	/// <summary>
	///		Obtiene el último elemento añadido
	/// </summary>
	public TypeData GetLast()
	{
		if (Items.Count > 0)
			return Items[Items.Count - 1];
		else
			return null;
	}

	/// <summary>
	///		Obtiene el primer elemento añadido
	/// </summary>
	public TypeData GetFirst()
	{
		if (Items.Count > 0)
			return Items[0];
		else
			return null;
	}

	/// <summary>
	///		Enumera los elementos
	/// </summary>
	public IEnumerable<TypeData> Enumerate()
	{
		for (int index = Items.Count - 1; index >= 0; index--)
			yield return Items[index];
	}

	/// <summary>
	///		Limpia los elementos
	/// </summary>
	public void Clear()
	{
		Items.Clear();
	}

	/// <summary>
	///		Elimina un elemento
	/// </summary>
	public void Remove(TypeData item)
	{
		Items.Remove(item);
	}

	/// <summary>
	///		Número máximo de elementos
	/// </summary>
	public int MaxItems { get; set; }

	/// <summary>
	///		Cuenta el número de elemento
	/// </summary>
	public int Count
	{
		get { return Items.Count; }
	}

	/// <summary>
	///		Indizador de la cola
	/// </summary>
	public TypeData this[int index]
	{
		get { return Items[index]; }
	}

	/// <summary>
	///		Elementos
	/// </summary>
	private List<TypeData> Items { get; } = [];
}
