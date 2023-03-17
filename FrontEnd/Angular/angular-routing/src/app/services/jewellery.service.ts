
import { GoldOrnament } from '../models/gold-ornament';
@Injectable({
  providedIn: 'root'
})

export class JewelleryService {
gc:Array<GoldOrnament> = []
  constructor() { }
addOrnament(go:GoldOrnament){
  this.gc.push(go);
}
}




