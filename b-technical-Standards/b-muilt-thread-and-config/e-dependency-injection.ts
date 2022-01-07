// Exemplo mais complexo em JS

//#region injector-bootstrapper.ts

import { container } from 'tsyringe';
import { BankLists } from '@services/bank-lists';

container.register('BankLists', BankLists);

//#endregion


//#region bank-lists.ts

import { injectable } from 'tsyringe';

@injectable()
export class BankLIsts {
  async nameListOfBanks() {
    return ...listOfNames;
  }
}

//#endregion


//#region bank-service.ts
import { inject } from 'tsyringe';

export class BankService {
  constructor(@inject('BanksLists') private readonly bankLists) { }
  // injetou uma classe/serviço no construtor sem precisar instanciar
  // e colocou o nome de bankLists
  async listBanks() {
    return await bankLists.nameListOfBanks();
  }
}
//#endregion