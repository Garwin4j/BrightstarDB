﻿ 

// -----------------------------------------------------------------------
// <autogenerated>
//    This code was generated from a template.
//
//    Changes to this file may cause incorrect behaviour and will be lost
//    if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using BrightstarDB.Client;
using BrightstarDB.EntityFramework;

namespace BrightstarDB.Samples.EntityFramework.GettingStarted 
{
    public partial class MyEntityContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static MyEntityContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Samples.EntityFramework.GettingStarted.IActor));
    		TypeMappings.AddImplMapping<BrightstarDB.Samples.EntityFramework.GettingStarted.IActor, BrightstarDB.Samples.EntityFramework.GettingStarted.Actor>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Samples.EntityFramework.GettingStarted.IFilm));
    		TypeMappings.AddImplMapping<BrightstarDB.Samples.EntityFramework.GettingStarted.IFilm, BrightstarDB.Samples.EntityFramework.GettingStarted.Film>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the Brightstar Data Object Store that will provide the entity objects</param>
    	public MyEntityContext(IDataObjectStore dataObjectStore) : base(TypeMappings, dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
    	public MyEntityContext(string connectionString, bool? enableOptimisticLocking=null) : base(TypeMappings, connectionString, enableOptimisticLocking)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
    	public MyEntityContext() : base(TypeMappings)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Actors = 	new BrightstarEntitySet<BrightstarDB.Samples.EntityFramework.GettingStarted.IActor>(this);
    		Films = 	new BrightstarEntitySet<BrightstarDB.Samples.EntityFramework.GettingStarted.IFilm>(this);
    	}
    	
    	public IEntitySet<BrightstarDB.Samples.EntityFramework.GettingStarted.IActor> Actors
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Samples.EntityFramework.GettingStarted.IFilm> Films
    	{
    		get; private set;
    	}
    	
    }
}
namespace BrightstarDB.Samples.EntityFramework.GettingStarted 
{
    
    public partial class Actor : BrightstarEntityObject, IActor 
    {
    	public Actor(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Actor() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Samples.EntityFramework.GettingStarted.IActor
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public System.DateTime DateOfBirth
    	{
            		get { return GetRelatedProperty<System.DateTime>("DateOfBirth"); }
            		set { SetRelatedProperty("DateOfBirth", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Samples.EntityFramework.GettingStarted.IFilm> Films
    	{
    		get { return GetRelatedObjects<BrightstarDB.Samples.EntityFramework.GettingStarted.IFilm>("Films"); }
    		set { SetRelatedObjects("Films", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.Samples.EntityFramework.GettingStarted 
{
    
    public partial class Film : BrightstarEntityObject, IFilm 
    {
    	public Film(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Film() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Samples.EntityFramework.GettingStarted.IFilm
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Samples.EntityFramework.GettingStarted.IActor> Actors
    	{
    		get { return GetRelatedObjects<BrightstarDB.Samples.EntityFramework.GettingStarted.IActor>("Actors"); }
    		set { SetRelatedObjects("Actors", value); }
    								}
    	#endregion
    }
}
