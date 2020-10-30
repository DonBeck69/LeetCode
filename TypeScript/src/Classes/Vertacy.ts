export class Vertacy {
    constructor (vertacy: Partial<Vertacy>){
        this.Edges = new Set<number>();
    }

    public ID: number;
    public Edges: Set<number>;
    public Visited: boolean;
    public Used: boolean;
}