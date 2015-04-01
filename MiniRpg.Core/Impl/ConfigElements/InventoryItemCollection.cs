namespace MiniRpg.Core.Impl.ConfigElements
{
    using System;
    using System.Configuration;

    public class InventoryItemCollection : ConfigurationElementCollection
	{
		public InventoryItemCollection()
		{
			// Add one item to the collection.  This is 
			// not necessary; could leave the collection  
			// empty until items are added to it outside 
			// the constructor.
			var item = 
				(InventoryItemConfigElement)this.CreateNewElement();
			this.Add(item);
		}

		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return 

					ConfigurationElementCollectionType.AddRemoveClearMap;
			}
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new InventoryItemConfigElement();
		}

		protected override ConfigurationElement CreateNewElement(string elementName)
		{
			return new InventoryItemConfigElement(elementName);
		}

		protected override Object GetElementKey(ConfigurationElement element)
		{
			return ((InventoryItemConfigElement)element).Name;
		}

		public new string AddElementName
		{
			get
			{ return base.AddElementName; }

			set
			{ base.AddElementName = value; }

		}

		public new string ClearElementName
		{
			get
			{ return base.ClearElementName; }

			set
			{ base.ClearElementName = value; }

		}

		public new string RemoveElementName
		{
			get
			{ return base.RemoveElementName; }
		}

		public new int Count
		{
			get { return base.Count; }
		}

		public InventoryItemConfigElement this[int index]
		{
			get
			{
				return (InventoryItemConfigElement)this.BaseGet(index);
			}
			set
			{
				if (this.BaseGet(index) != null)
				{
					this.BaseRemoveAt(index);
				}
				this.BaseAdd(index, value);
			}
		}

		new public InventoryItemConfigElement this[string Name]
		{
			get
			{
				return (InventoryItemConfigElement)this.BaseGet(Name);
			}
		}

		public int IndexOf(InventoryItemConfigElement item)
		{
			return this.BaseIndexOf(item);
		}

		public void Add(InventoryItemConfigElement item)
		{
			this.BaseAdd(item);
			// Add custom code here.
		}

		protected override void BaseAdd(ConfigurationElement element)
		{
			this.BaseAdd(element, false);
			// Add custom code here.
		}

		public void Remove(InventoryItemConfigElement item)
		{
			if (this.BaseIndexOf(item) >= 0)
				this.BaseRemove(item.Name);
		}

		public void RemoveAt(int index)
		{
			this.BaseRemoveAt(index);
		}

		public void Remove(string name)
		{
			this.BaseRemove(name);
		}

		public void Clear()
		{
			this.BaseClear();
			// Add custom code here.
		}
	}
	
}
