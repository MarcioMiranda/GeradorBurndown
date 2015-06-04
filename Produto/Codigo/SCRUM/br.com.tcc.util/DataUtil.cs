using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.tcc.util
{
    public class DataUtil
    {

	private const String FORMATO_DATA = "dd/MM/yyyy";
	
	public static DateTime converteStringParaDate(String data) {  //throws ParseException
		if (data == null || data.Equals(""))
			return DateTime.MinValue;
		
        DateTime date = DateTime.MinValue;
        try {
            //DateFormat formatter = new SimpleDateFormat(FORMATO_DATA);
            date = DateTime.Parse(data);
        } catch (Exception e) {
            throw e;
        }
        return date;
	}
	
	public static String dateToString(DateTime data){
		
        return data.ToString(FORMATO_DATA);  
	}
	
    
	public static DateTime adicionarDiasData(DateTime data, int dias){
		return DateTime.Now.AddDays(dias);
	}
    
    }
}
