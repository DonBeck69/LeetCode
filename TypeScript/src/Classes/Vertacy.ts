export class Vertacy {
    constructor (init?: Partial<Vertacy>){
        Object.assign(this, init);
    }

    public ID: number;
    public Edges: Set<number> = new Set<number>();
    public Visited: boolean = false;
    public Used: boolean = false;
}