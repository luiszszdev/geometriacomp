//using capaDatos.Modelos;

//namespace capaDatos;

//public class Horarios
//{

//    public List<Clases> horarioClases { get; set; }
//    public List<string> horasDisponibles { get; set; }
//    public Horarios(List<Clases> _horarioclases, List<string> _horasDisponibles)    
//    {
//        horarioClases = _horarioclases;
//        horasDisponibles = _horasDisponibles;

//    }
//    public bool isConflict(Clases nuevaClase)
//    {
//        foreach (var Clase in horarioClases)
//        {
//            if (Clase.profesor == nuevaClase.profesor && Clase.hora == nuevaClase.hora)
//                return true;
//            if (Clase.grupo == nuevaClase.grupo && Clase.hora == nuevaClase.hora)
//                return true;
//            if (Clase.salon == nuevaClase.salon && Clase.hora == nuevaClase.hora)
//                return true;
//        }
//        return false;
//    }
//    public bool addClase(Clases nuevaClase)
//    {
//        if(!isConflict(nuevaClase))
//        {
//            horarioClases.Add(nuevaClase);
//            return true;            
//        }
//        return false;
//    }
//    public void CreateSchedule(List<Asignatura> Materias, List<Grupos> grupos, 
//    List<Profesores> profesores, List<Salones> salones) 
//    {
//        if (Materias.Count == 0 || grupos.Count == 0 || profesores.Count == 0 || salones.Count == 0)
//        {
//            Console.WriteLine("No hay suficientes datos para crear un horario");
//            return;
//        }
//        Random ran = new Random();
        
//        foreach(var asignatura in Materias)
//        {
//            foreach(var grupo in grupos)
//            {
//                if (Materias.Count == 0) continue;

//                Profesores profesor = asignatura.asignaturaProfesores[ran.Next(asignatura.asignaturaProfesores.Count)];
//                Salones salon = salones[ran.Next(salones.Count)];
//                string hora = horasDisponibles[ran.Next(horasDisponibles.Count)];

//                Clases nuevaClase = new Clases(asignatura, grupo, profesor, salon, hora);
                
//                if (!isConflict(nuevaClase))
//                {
//                    horarioClases.Add(nuevaClase);
//                }
//            }
//        }
//    }
//}
