import { Vertacy } from "./Classes/Vertacy";

export class CourseSchedule {
    public CanFinish (numCourses: number, prerequisits: number[][]) {

        let vertacies: Array<Vertacy> = new Array<Vertacy>();
        for (let i: number = 0; i < numCourses; i++)
        {
            let vertacy: Vertacy = new Vertacy({ID: i});
            vertacies.push(vertacy);
        }

        for (let n: number = 0; n < prerequisits.length; n++)
        {
            vertacies[prerequisits[n][0]].Edges.add(prerequisits[n][1]);                
        }

        for (let i: number = 0; i < numCourses; i++)
        {
            if (this.DepthFirstSearchCanFinish(vertacies, i) == false)
            {
                return false;
            }
        }

        return true;
    }

    public DepthFirstSearchCanFinish (Vertacies: Array<Vertacy>, VertacyId: number): boolean {
        if (Vertacies[VertacyId].Used) {
            return false;
        }

        if (Vertacies[VertacyId].Edges.size > 0 && Vertacies[VertacyId].Visited === false){
            Vertacies[VertacyId].Visited = true;
            Vertacies[VertacyId].Used = true;
            Vertacies[VertacyId].Edges.forEach((v: number) => {
                if (this.DepthFirstSearchCanFinish(Vertacies, v) ==  false){
                    return false;
                }

                Vertacies[VertacyId].Used = true;
            });
        }
        return true;
    }
}

