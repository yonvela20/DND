using System;
using System.Data;
using Serpis.Ad;

namespace CreadorDnd
{
    public class CreadorDao
    {
        public const string SelectAll = "select * from personaje order by id";

        public static Creador Load(object id)
		{
			IDbCommand dbCommand = App.Instance.Connection.CreateCommand();
			dbCommand.CommandText = "select * from personaje where id = @id";
			DbCommandHelper.AddParameter(dbCommand, "id", id);
			IDataReader dataReader = dbCommand.ExecuteReader();
			dataReader.Read();//TODO tratamiento de excepciones
			
            string nombre = (string)dataReader["nombre"];
			int fuerza = (int)dataReader["fuerza"];
            int destreza = (int)dataReader["destreza"];
            int constitucion = (int)dataReader["constitucion"];
            int inteligencia = (int)dataReader["inteligencia"];
            int carisma = (int)dataReader["carisma"];
            int sabiduria = (int)dataReader["sabiduria"];


			
            int raza = dataReader["raza"] is DBNull ? 0
				: (int)dataReader["raza"];
			dataReader.Close();
            Creador personaje = new Creador();
			personaje.Id = Convert.ToInt64(id);
			personaje.Nombre = nombre;
			personaje.Raza = raza;
            personaje.Fuerza = fuerza;
            personaje.Destreza = destreza;
            personaje.Constitucion = constitucion;
            personaje.Inteligencia = inteligencia;
            personaje.Carisma = carisma;
            personaje.Sabiduria = sabiduria;
			return personaje;
		}

		public static void Save(Creador personaje)
		{
			if (personaje.Id == 0)
				Insert(personaje);
			else
				Update(personaje);
		}

        private static void Insert(Creador personaje)
		{
			IDbCommand dbCommand = App.Instance.Connection.CreateCommand();
			dbCommand.CommandText = 
                "insert into personaje (nombre, raza, fuerza, destreza, constitucion, inteligencia, carisma, sabiduria) values (@nombre, @raza, @fuerza, @destreza, @constitucion, @inteligencia, @carisma, @sabiduria)";
            DbCommandHelper.AddParameter(dbCommand, "nombre", personaje.Nombre);
			DbCommandHelper.AddParameter(dbCommand, "raza", personaje.Raza);
			
            DbCommandHelper.AddParameter(dbCommand, "fuerza", personaje.Fuerza);
			DbCommandHelper.AddParameter(dbCommand, "destreza", personaje.Destreza);
            DbCommandHelper.AddParameter(dbCommand, "constitucion", personaje.Constitucion);
            DbCommandHelper.AddParameter(dbCommand, "inteligencia", personaje.Inteligencia);
            DbCommandHelper.AddParameter(dbCommand, "carisma", personaje.Carisma);
            DbCommandHelper.AddParameter(dbCommand, "sabiduria", personaje.Sabiduria);


            object raza = personaje.Raza;
            if (personaje.Raza == 0)
			{
                personaje = null;
			}
			dbCommand.ExecuteNonQuery();
		}

		private static void Update(Creador personaje)
		{
			IDbCommand dbCommand = App.Instance.Connection.CreateCommand();
			dbCommand.CommandText = "update personaje set nombre = @nombre, raza = @raza, fuerza = @fuerza, destreza = @destreza, constitucion = @constitucion, inteligencia = @inteligencia, carisma = @carisma, sabiduria = @sabiduria where id = @id ";
			DbCommandHelper.AddParameter(dbCommand, "nombre", personaje.Nombre);
			DbCommandHelper.AddParameter(dbCommand, "raza", personaje.Raza);

			DbCommandHelper.AddParameter(dbCommand, "fuerza", personaje.Fuerza);
			DbCommandHelper.AddParameter(dbCommand, "destreza", personaje.Destreza);
			DbCommandHelper.AddParameter(dbCommand, "constitucion", personaje.Constitucion);
			DbCommandHelper.AddParameter(dbCommand, "inteligencia", personaje.Inteligencia);
			DbCommandHelper.AddParameter(dbCommand, "carisma", personaje.Carisma);
			DbCommandHelper.AddParameter(dbCommand, "sabiduria", personaje.Sabiduria);

			object raza = personaje.Raza;
			if (personaje.Raza == 0)
			{
				personaje = null;
			}
			dbCommand.ExecuteNonQuery();
		}

		public static void Delete(object id)
		{
			IDbCommand dbCommand = App.Instance.Connection.CreateCommand();
			dbCommand.CommandText = "delete from personaje where id = @id";
			DbCommandHelper.AddParameter(dbCommand, "id", id);
			dbCommand.ExecuteNonQuery();
		}
	}
}
