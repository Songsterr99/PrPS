using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySite
{

    public enum FormOfEducation : int
    {

        extramuralForm = 1,
        intramuralForm,
        partTimeForm

    }//end FormOfEducation

    /// <summary>
    /// Возможные значения типа пользователя после входа в систему
    /// </summary>
    public enum TypeOfUser : int
    {

        administrator = 1,
        applicant,
        university_worker

    }//end TypeOfUser

    /// <summary>
    /// Возможные виды запросов
    /// </summary>
    public enum TypeOfRequest : int
    {

        getInfo = 1,
        changeInfo,
        checkInfo

    }//end TypeOfRequest

    /// <summary>
    /// факультет
    /// </summary>
    public class Faculty
    {
        private int Code { get; set; }
        private string Name { get; set; }
        private string ShortName { get; set; }

    }//end <<entity>> Faculty

    /// <summary>
    /// Руководитель учебного подразделения
    /// </summary>
    public class Head
    {
        private string Name { get; set; }
        private string ScDegree { get; set; }
        private string ScRank { get; set; }
        private string StartDate { get; set; }
        private string EndDate { get; set; }
    }//end <<entity>> Head

    /// <summary>
    /// Класс, который содержит информацию о пользователе, который вошел в систему
    /// </summary>
    public class User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public TypeOfUser Type { get; private set; }

        public User(string login, string password, int type)
        {
            Login = login;
            Password = password;
            Type = (TypeOfUser)Enum.GetValues(typeof(TypeOfUser)).GetValue(type);
        }

    }//end <<entity>>User

    public class Subject
    {
        private string Name { get; set; }
        private int PassingScore { get; set; }
    }

    /// <summary>
    /// Speciality
    /// </summary>
    public class Speciality
    {
        private int Code { get; set; }
        private string Name { get; set; }
        private string ShortName { get; set; }
    }//end <<entity>> Speciality

    /// <summary>
    /// Запрос в базу данных
    /// </summary>
    public class Request {

	private string information;
    private TypeOfRequest type;

	public Request()
    {

    }

    ~Request()
    {

    }

    public void getInfo()
    {

    }

    public void getType()
    {

    }

    /// 
    /// <param name="information"></param>
    /// <param name="type"></param>
    public void MakeRequest(string information, TypeOfRequest type)
    {

    }

}//end <<entity>> Request
}
