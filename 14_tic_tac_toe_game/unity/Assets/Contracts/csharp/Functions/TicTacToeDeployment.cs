using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.Contracts;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Truffle.Functions
{
    public partial class TicTacToeDeployment : TicTacToeDeploymentBase
    {
        public TicTacToeDeployment() : base(BYTECODE) { }
        public TicTacToeDeployment(string byteCode) : base(byteCode) { }
    }

    public class TicTacToeDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x60a060405234801561001057600080fd5b5060405161001d90610072565b604051809103906000f080158015610039573d6000803e3d6000fd5b5073ffffffffffffffffffffffffffffffffffffffff1660808173ffffffffffffffffffffffffffffffffffffffff168152505061007f565b610ba180610dcb83390190565b608051610d246100a76000396000818160f10152818161030201526106760152610d246000f3fe60806040526004361061003f5760003560e01c806331b3eb94146100445780639f98985d1461006d578063e2982c2114610096578063eb23b56b146100d3575b600080fd5b34801561005057600080fd5b5061006b60048036038101906100669190610801565b6100ef565b005b34801561007957600080fd5b50610094600480360381019061008f9190610864565b61017d565b005b3480156100a257600080fd5b506100bd60048036038101906100b891906108e2565b6102fe565b6040516100ca919061091e565b60405180910390f35b6100ed60048036038101906100e89190610939565b6103a1565b005b7f000000000000000000000000000000000000000000000000000000000000000073ffffffffffffffffffffffffffffffffffffffff166351cff8d9826040518263ffffffff1660e01b81526004016101489190610988565b600060405180830381600087803b15801561016257600080fd5b505af1158015610176573d6000803e3d6000fd5b5050505050565b60008281548110610191576101906109a3565b5b906000526020600020906004020160030160009054906101000a900460ff16156101f0576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004016101e790610a55565b60405180910390fd5b6000808381548110610205576102046109a3565b5b90600052602060002090600402016001018260028110610228576102276109a3565b5b0160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690506000808481548110610261576102606109a3565b5b906000526020600020906004020160000154905060016000858154811061028b5761028a6109a3565b5b906000526020600020906004020160030160006101000a81548160ff0219169083151502179055506102bd8282610674565b7f9e59e9b0ec1755ccaf2fd4a7ed4ad5b0a678626e91834aee53ebdf1356bd390a8483836040516102f093929190610a84565b60405180910390a150505050565b60007f000000000000000000000000000000000000000000000000000000000000000073ffffffffffffffffffffffffffffffffffffffff1663e3a9db1a836040518263ffffffff1660e01b81526004016103599190610abb565b602060405180830381865afa158015610376573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061039a9190610aeb565b9050919050565b600034116103e4576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004016103db90610b64565b60405180910390fd5b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1603610453576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040161044a90610bd0565b60405180910390fd5b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16036104c2576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004016104b990610c3c565b60405180910390fd5b8073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1603610530576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040161052790610cce565b60405180910390fd5b600080805490509050600060405180604001604052808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681525090506000604051806060016040528034815260200183815260200160001515815250908060018154018082558091505060019003906000526020600020906004020160009091909190915060008201518160000155602082015181600101906002610614929190610704565b5060408201518160030160006101000a81548160ff02191690831515021790555050507f50ad08f58a27f2851d7e3a1b3a6a46b290f2ce677e99642d30ff639721e7779082604051610666919061091e565b60405180910390a150505050565b7f000000000000000000000000000000000000000000000000000000000000000073ffffffffffffffffffffffffffffffffffffffff1663f340fa0182846040518363ffffffff1660e01b81526004016106ce9190610abb565b6000604051808303818588803b1580156106e757600080fd5b505af11580156106fb573d6000803e3d6000fd5b50505050505050565b8260028101928215610770579160200282015b8281111561076f5782518260006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555091602001919060010190610717565b5b50905061077d9190610781565b5090565b5b8082111561079a576000816000905550600101610782565b5090565b600080fd5b600073ffffffffffffffffffffffffffffffffffffffff82169050919050565b60006107ce826107a3565b9050919050565b6107de816107c3565b81146107e957600080fd5b50565b6000813590506107fb816107d5565b92915050565b6000602082840312156108175761081661079e565b5b6000610825848285016107ec565b91505092915050565b6000819050919050565b6108418161082e565b811461084c57600080fd5b50565b60008135905061085e81610838565b92915050565b6000806040838503121561087b5761087a61079e565b5b60006108898582860161084f565b925050602061089a8582860161084f565b9150509250929050565b60006108af826107a3565b9050919050565b6108bf816108a4565b81146108ca57600080fd5b50565b6000813590506108dc816108b6565b92915050565b6000602082840312156108f8576108f761079e565b5b6000610906848285016108cd565b91505092915050565b6109188161082e565b82525050565b6000602082019050610933600083018461090f565b92915050565b600080604083850312156109505761094f61079e565b5b600061095e858286016108cd565b925050602061096f858286016108cd565b9150509250929050565b610982816107c3565b82525050565b600060208201905061099d6000830184610979565b92915050565b7f4e487b7100000000000000000000000000000000000000000000000000000000600052603260045260246000fd5b600082825260208201905092915050565b7f63616e6e6f7420656e6420612067616d6520776869636820697320616c72656160008201527f647920656e646564000000000000000000000000000000000000000000000000602082015250565b6000610a3f6028836109d2565b9150610a4a826109e3565b604082019050919050565b60006020820190508181036000830152610a6e81610a32565b9050919050565b610a7e816108a4565b82525050565b6000606082019050610a99600083018661090f565b610aa66020830185610a75565b610ab3604083018461090f565b949350505050565b6000602082019050610ad06000830184610a75565b92915050565b600081519050610ae581610838565b92915050565b600060208284031215610b0157610b0061079e565b5b6000610b0f84828501610ad6565b91505092915050565b7f6a61636b706f74206d7573742062652067726561746572207468616e20300000600082015250565b6000610b4e601e836109d2565b9150610b5982610b18565b602082019050919050565b60006020820190508181036000830152610b7d81610b41565b9050919050565b7f706c61796572205820616464726573732063616e6e6f7420626520656d707479600082015250565b6000610bba6020836109d2565b9150610bc582610b84565b602082019050919050565b60006020820190508181036000830152610be981610bad565b9050919050565b7f706c61796572204f20616464726573732063616e6e6f7420626520656d707479600082015250565b6000610c266020836109d2565b9150610c3182610bf0565b602082019050919050565b60006020820190508181036000830152610c5581610c19565b9050919050565b7f706c61796572205820616e6420706c61796572204f2063616e6e6f742068617660008201527f65207468652073616d65207061796f7574206164647265737300000000000000602082015250565b6000610cb86039836109d2565b9150610cc382610c5c565b604082019050919050565b60006020820190508181036000830152610ce781610cab565b905091905056fea2646970667358221220c20e48cb316cd224554e2ca97e5d643d9bd625aa1af6e1343fa3c3209105750764736f6c63430008120033608060405234801561001057600080fd5b5061002d61002261003260201b60201c565b61003a60201b60201c565b6100fe565b600033905090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050816000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055508173ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a35050565b610a948061010d6000396000f3fe6080604052600436106100555760003560e01c806351cff8d91461005a578063715018a6146100835780638da5cb5b1461009a578063e3a9db1a146100c5578063f2fde38b14610102578063f340fa011461012b575b600080fd5b34801561006657600080fd5b50610081600480360381019061007c91906106b2565b610147565b005b34801561008f57600080fd5b50610098610253565b005b3480156100a657600080fd5b506100af610267565b6040516100bc9190610700565b60405180910390f35b3480156100d157600080fd5b506100ec60048036038101906100e79190610747565b610290565b6040516100f9919061078d565b60405180910390f35b34801561010e57600080fd5b5061012960048036038101906101249190610747565b6102d9565b005b61014560048036038101906101409190610747565b61035c565b005b61014f610411565b6000600160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000205490506000600160008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002081905550610201818373ffffffffffffffffffffffffffffffffffffffff1661048f90919063ffffffff16565b8173ffffffffffffffffffffffffffffffffffffffff167f7084f5476618d8e60b11ef0d7d3f06914655adb8793e28ff7f018d4c76d505d582604051610247919061078d565b60405180910390a25050565b61025b610411565b6102656000610583565b565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b6000600160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020549050919050565b6102e1610411565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1603610350576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004016103479061082b565b60405180910390fd5b61035981610583565b50565b610364610411565b600034905080600160008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008282546103b8919061087a565b925050819055508173ffffffffffffffffffffffffffffffffffffffff167f2da466a7b24304f47e87fa2e1e5a81b9831ce54fec19055ce277ca2f39ba42c482604051610405919061078d565b60405180910390a25050565b610419610647565b73ffffffffffffffffffffffffffffffffffffffff16610437610267565b73ffffffffffffffffffffffffffffffffffffffff161461048d576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401610484906108fa565b60405180910390fd5b565b804710156104d2576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004016104c990610966565b60405180910390fd5b60008273ffffffffffffffffffffffffffffffffffffffff16826040516104f8906109b7565b60006040518083038185875af1925050503d8060008114610535576040519150601f19603f3d011682016040523d82523d6000602084013e61053a565b606091505b505090508061057e576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040161057590610a3e565b60405180910390fd5b505050565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050816000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055508173ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a35050565b600033905090565b600080fd5b600073ffffffffffffffffffffffffffffffffffffffff82169050919050565b600061067f82610654565b9050919050565b61068f81610674565b811461069a57600080fd5b50565b6000813590506106ac81610686565b92915050565b6000602082840312156106c8576106c761064f565b5b60006106d68482850161069d565b91505092915050565b60006106ea82610654565b9050919050565b6106fa816106df565b82525050565b600060208201905061071560008301846106f1565b92915050565b610724816106df565b811461072f57600080fd5b50565b6000813590506107418161071b565b92915050565b60006020828403121561075d5761075c61064f565b5b600061076b84828501610732565b91505092915050565b6000819050919050565b61078781610774565b82525050565b60006020820190506107a2600083018461077e565b92915050565b600082825260208201905092915050565b7f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160008201527f6464726573730000000000000000000000000000000000000000000000000000602082015250565b60006108156026836107a8565b9150610820826107b9565b604082019050919050565b6000602082019050818103600083015261084481610808565b9050919050565b7f4e487b7100000000000000000000000000000000000000000000000000000000600052601160045260246000fd5b600061088582610774565b915061089083610774565b92508282019050808211156108a8576108a761084b565b5b92915050565b7f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572600082015250565b60006108e46020836107a8565b91506108ef826108ae565b602082019050919050565b60006020820190508181036000830152610913816108d7565b9050919050565b7f416464726573733a20696e73756666696369656e742062616c616e6365000000600082015250565b6000610950601d836107a8565b915061095b8261091a565b602082019050919050565b6000602082019050818103600083015261097f81610943565b9050919050565b600081905092915050565b50565b60006109a1600083610986565b91506109ac82610991565b600082019050919050565b60006109c282610994565b9150819050919050565b7f416464726573733a20756e61626c6520746f2073656e642076616c75652c207260008201527f6563697069656e74206d61792068617665207265766572746564000000000000602082015250565b6000610a28603a836107a8565b9150610a33826109cc565b604082019050919050565b60006020820190508181036000830152610a5781610a1b565b905091905056fea2646970667358221220354bb74edbdf05d149d157365d8608295acae43a2591e4a56ca7003a2efa9c1764736f6c63430008120033";
        public TicTacToeDeploymentBase() : base(BYTECODE) { }
        public TicTacToeDeploymentBase(string byteCode) : base(byteCode) { }

    }
}