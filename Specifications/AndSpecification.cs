﻿namespace Specifications
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> _leftSpecification;
        private readonly ISpecification<T> _rightSpecification;

        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _leftSpecification = left;
            _rightSpecification = right;
        }

        public override bool IsSatisfiedBy(T entity)
        {
            return _leftSpecification.IsSatisfiedBy(entity) &&
                   _rightSpecification.IsSatisfiedBy(entity);
        }
    }
}