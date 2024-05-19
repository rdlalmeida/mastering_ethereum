// SPDX-License-Identifier: MIT
pragma solidity >=0.5.0 <0.9.0;

abstract contract EthPriceOracleInterface {
    function getLatestEthPrice() public virtual returns (uint256);
}
